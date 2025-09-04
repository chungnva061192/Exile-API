using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ExileCore2.PoEMemory.MemoryObjects;
using ExileCore2.Shared;
using ExileCore2.Shared.AtlasHelper;
using ExileCore2.Shared.Interfaces;
using Newtonsoft.Json;

namespace ExileCore2
{
	// Token: 0x02000012 RID: 18
	public abstract class BaseSettingsPlugin<TSettings> : IPlugin, IDisposable where TSettings : ISettings, new()
	{
		// Token: 0x06000065 RID: 101 RVA: 0x0016A884 File Offset: 0x0016A884
		protected BaseSettingsPlugin()
		{
			this.InternalName = base.GetType().Namespace;
			this.Name = this.InternalName;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0016A8B8 File Offset: 0x0016A8B8
		public List<ISettingsHolder> Drawers { get; } = new List<ISettingsHolder>();

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0016A8C0 File Offset: 0x0016A8C0
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0016A8C8 File Offset: 0x0016A8C8
		public GameController GameController { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0016A8D4 File Offset: 0x0016A8D4
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0016A8DC File Offset: 0x0016A8DC
		public Graphics Graphics { get; private set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0016A8E8 File Offset: 0x0016A8E8
		public TSettings Settings
		{
			get
			{
				return (TSettings)((object)this._Settings);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0016A8F8 File Offset: 0x0016A8F8
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0016A900 File Offset: 0x0016A900
		public ISettings _Settings { get; private set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0016A90C File Offset: 0x0016A90C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0016A914 File Offset: 0x0016A914
		public bool CanUseMultiThreading { get; protected set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0016A920 File Offset: 0x0016A920
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0016A928 File Offset: 0x0016A928
		public string Description { get; protected set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0016A934 File Offset: 0x0016A934
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0016A93C File Offset: 0x0016A93C
		public string DirectoryName { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0016A948 File Offset: 0x0016A948
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0016A950 File Offset: 0x0016A950
		public string DirectoryFullName { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0016A95C File Offset: 0x0016A95C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0016A964 File Offset: 0x0016A964
		public bool Force { get; protected set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0016A970 File Offset: 0x0016A970
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0016A978 File Offset: 0x0016A978
		public bool Initialized { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0016A984 File Offset: 0x0016A984
		public string InternalName { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0016A98C File Offset: 0x0016A98C
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0016A994 File Offset: 0x0016A994
		public string Name { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0016A9A0 File Offset: 0x0016A9A0
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0016A9A8 File Offset: 0x0016A9A8
		public int Order { get; protected set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0016A9B4 File Offset: 0x0016A9B4
		public string ConfigDirectory
		{
			get
			{
				return this.GameController.Settings.GetPluginSettingsDirectory(this);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0016A9C8 File Offset: 0x0016A9C8
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0016A9D0 File Offset: 0x0016A9D0
		public PluginManager PluginManager { get; private set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0016A9DC File Offset: 0x0016A9DC
		public CancellationToken ZoneCancellationToken
		{
			get
			{
				return this.PluginManager.ZoneCancellationToken;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0016A9EC File Offset: 0x0016A9EC
		public void _LoadSettings()
		{
			try
			{
				string text = this.GameController.Settings.LoadSettings(this);
				bool flag = text != null;
				if (flag)
				{
					this._Settings = JsonConvert.DeserializeObject<TSettings>(text, SettingsContainer.jsonSettings);
				}
			}
			catch (Exception ex)
			{
				DebugWindow.LogError(ex.ToString());
			}
			if (this._Settings == null)
			{
				this._Settings = Activator.CreateInstance<TSettings>();
			}
			SettingsParser.Parse(this._Settings, this.Drawers, -1);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0016AA80 File Offset: 0x0016AA80
		public void _SaveSettings()
		{
			bool flag = this._Settings == null;
			if (flag)
			{
				throw new NullReferenceException("Plugin settings is null");
			}
			this.GameController.Settings.SaveSettings(this);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0016AAB8 File Offset: 0x0016AAB8
		public virtual void AreaChange(AreaInstance area)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0016AABC File Offset: 0x0016AABC
		public virtual void Dispose()
		{
			this.OnClose();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0016AAC8 File Offset: 0x0016AAC8
		public virtual void DrawSettings()
		{
			foreach (ISettingsHolder settingsHolder in this.Drawers)
			{
				settingsHolder.Draw();
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0016AB20 File Offset: 0x0016AB20
		public virtual void EntityAdded(Entity entity)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0016AB24 File Offset: 0x0016AB24
		public virtual void EntityAddedAny(Entity entity)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0016AB28 File Offset: 0x0016AB28
		public virtual void EntityIgnored(Entity entity)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0016AB2C File Offset: 0x0016AB2C
		public virtual void EntityRemoved(Entity entity)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0016AB30 File Offset: 0x0016AB30
		public virtual void OnLoad()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0016AB34 File Offset: 0x0016AB34
		public virtual void OnUnload()
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0016AB38 File Offset: 0x0016AB38
		public virtual bool Initialise()
		{
			return true;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0016AB4C File Offset: 0x0016AB4C
		public void LogMsg(string msg)
		{
			DebugWindow.LogMsg(msg);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0016AB58 File Offset: 0x0016AB58
		public virtual void OnClose()
		{
			this._SaveSettings();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0016AB64 File Offset: 0x0016AB64
		public virtual void ReceiveEvent(string eventId, object args)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0016AB68 File Offset: 0x0016AB68
		public void PublishEvent(string eventId, object args)
		{
			this.PluginManager.ReceivePluginEvent(eventId, args, this);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0016AB7C File Offset: 0x0016AB7C
		public virtual void OnPluginSelectedInMenu()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0016AB80 File Offset: 0x0016AB80
		public virtual void Tick()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0016AB84 File Offset: 0x0016AB84
		public virtual void Render()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0016AB88 File Offset: 0x0016AB88
		public void LogError(string msg)
		{
			DebugWindow.LogError("[" + this.Name + "] " + msg);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0016ABA8 File Offset: 0x0016ABA8
		public void LogError(string msg, float time)
		{
			DebugWindow.LogError("[" + this.Name + "] " + msg, time);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0016ABC8 File Offset: 0x0016ABC8
		public void LogMessage(string msg, float time, Color clr)
		{
			DebugWindow.LogMsg("[" + this.Name + "] " + msg, time, clr);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0016ABEC File Offset: 0x0016ABEC
		public void LogMessage(string msg)
		{
			DebugWindow.LogMsg("[" + this.Name + "] " + msg);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0016AC0C File Offset: 0x0016AC0C
		public void LogMessage(string msg, float time)
		{
			DebugWindow.LogMsg("[" + this.Name + "] " + msg, time);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0016AC2C File Offset: 0x0016AC2C
		public virtual void OnPluginDestroyForHotReload()
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0016AC30 File Offset: 0x0016AC30
		public void SetApi(GameController gameController, Graphics graphics, PluginManager pluginManager)
		{
			this.GameController = gameController;
			this.Graphics = graphics;
			this.PluginManager = pluginManager;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0016AC4C File Offset: 0x0016AC4C
		public void PostNotification(PluginNotification notification)
		{
			this.PluginManager.Notifications[new PluginManager.NotificationId(this.InternalName, notification.Category, notification.Id)] = notification;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0016AC78 File Offset: 0x0016AC78
		public void RemoveAllNotifications()
		{
			foreach (KeyValuePair<PluginManager.NotificationId, PluginNotification> keyValuePair in (from x in this.PluginManager.Notifications
			where x.Key.PluginId == this.InternalName
			select x).ToList<KeyValuePair<PluginManager.NotificationId, PluginNotification>>())
			{
				PluginNotification pluginNotification;
				this.PluginManager.Notifications.Remove(keyValuePair.Key, out pluginNotification);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0016AD00 File Offset: 0x0016AD00
		public void RemoveNotifications(string category)
		{
			IEnumerable<KeyValuePair<PluginManager.NotificationId, PluginNotification>> notifications = this.PluginManager.Notifications;
			Func<KeyValuePair<PluginManager.NotificationId, PluginNotification>, bool> <>9__0;
			Func<KeyValuePair<PluginManager.NotificationId, PluginNotification>, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((KeyValuePair<PluginManager.NotificationId, PluginNotification> x) => x.Key.PluginId == this.InternalName && x.Key.Category == category));
			}
			foreach (KeyValuePair<PluginManager.NotificationId, PluginNotification> keyValuePair in notifications.Where(predicate).ToList<KeyValuePair<PluginManager.NotificationId, PluginNotification>>())
			{
				PluginNotification pluginNotification;
				this.PluginManager.Notifications.Remove(keyValuePair.Key, out pluginNotification);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0016ADB0 File Offset: 0x0016ADB0
		public void RemoveNotification(string category, string id)
		{
			IEnumerable<KeyValuePair<PluginManager.NotificationId, PluginNotification>> notifications = this.PluginManager.Notifications;
			Func<KeyValuePair<PluginManager.NotificationId, PluginNotification>, bool> <>9__0;
			Func<KeyValuePair<PluginManager.NotificationId, PluginNotification>, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((KeyValuePair<PluginManager.NotificationId, PluginNotification> x) => x.Key.PluginId == this.InternalName && x.Key.Category == category && x.Key.Notification == id));
			}
			foreach (KeyValuePair<PluginManager.NotificationId, PluginNotification> keyValuePair in notifications.Where(predicate).ToList<KeyValuePair<PluginManager.NotificationId, PluginNotification>>())
			{
				PluginNotification pluginNotification;
				this.PluginManager.Notifications.Remove(keyValuePair.Key, out pluginNotification);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0016AE64 File Offset: 0x0016AE64
		public AtlasTexture GetAtlasTexture(string textureName)
		{
			bool flag = this._atlasTextures == null;
			if (flag)
			{
				string text = Path.Combine(this.DirectoryFullName, "textures");
				string[] files = Directory.GetFiles(text, "*.json");
				bool flag2 = files.Length == 0;
				if (flag2)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
					defaultInterpolatedStringHandler.AppendFormatted(this.Name);
					defaultInterpolatedStringHandler.AppendLiteral("': Can't find atlas json config file in '");
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral("' ");
					this.LogError(defaultInterpolatedStringHandler.ToStringAndClear() + "(expecting config 'from Free texture packer' program)", 20f);
					this._atlasTextures = new AtlasTexturesProcessor("%AtlasNotFound%");
					return null;
				}
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[0]);
				bool flag3 = files.Length > 1;
				if (flag3)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(82, 3);
					defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
					defaultInterpolatedStringHandler.AppendFormatted(this.Name);
					defaultInterpolatedStringHandler.AppendLiteral("': Found multiple atlas configs in folder '");
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral("', ");
					defaultInterpolatedStringHandler.AppendLiteral("selecting the first one ''");
					defaultInterpolatedStringHandler.AppendFormatted(fileNameWithoutExtension);
					defaultInterpolatedStringHandler.AppendLiteral("''");
					this.LogError(defaultInterpolatedStringHandler.ToStringAndClear(), 20f);
				}
				string text2 = Path.Combine(this.DirectoryFullName, "textures\\" + fileNameWithoutExtension + ".png");
				bool flag4 = !File.Exists(text2);
				if (flag4)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
					defaultInterpolatedStringHandler.AppendFormatted(this.Name);
					defaultInterpolatedStringHandler.AppendLiteral("': Can't find atlas png texture file in '");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					defaultInterpolatedStringHandler.AppendLiteral("' ");
					this.LogError(defaultInterpolatedStringHandler.ToStringAndClear(), 20f);
					this._atlasTextures = new AtlasTexturesProcessor(fileNameWithoutExtension);
					return null;
				}
				this._atlasTextures = new AtlasTexturesProcessor(files[0], text2);
				this.Graphics.InitImage(text2, false);
			}
			return this._atlasTextures.GetTextureByName(textureName);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0016B094 File Offset: 0x0016B094
		public AtlasTexturesProcessor CreateAtlas(string configPath, string texturePath)
		{
			bool flag = !File.Exists(configPath);
			AtlasTexturesProcessor result;
			if (flag)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
				defaultInterpolatedStringHandler.AppendFormatted(this.Name);
				defaultInterpolatedStringHandler.AppendLiteral("': Can't find atlas json config file in '");
				defaultInterpolatedStringHandler.AppendFormatted(configPath);
				defaultInterpolatedStringHandler.AppendLiteral("'");
				this.LogError(defaultInterpolatedStringHandler.ToStringAndClear(), 20f);
				result = new AtlasTexturesProcessor("%AtlasNotFound%");
			}
			else
			{
				bool flag2 = !File.Exists(texturePath);
				if (flag2)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Plugin '");
					defaultInterpolatedStringHandler.AppendFormatted(this.Name);
					defaultInterpolatedStringHandler.AppendLiteral("': Can't find atlas png texture file in '");
					defaultInterpolatedStringHandler.AppendFormatted(texturePath);
					defaultInterpolatedStringHandler.AppendLiteral("' ");
					this.LogError(defaultInterpolatedStringHandler.ToStringAndClear(), 20f);
					result = new AtlasTexturesProcessor("%AtlasNotFound%");
				}
				else
				{
					this.Graphics.InitImage(texturePath, false);
					result = new AtlasTexturesProcessor(configPath, texturePath);
				}
			}
			return result;
		}

		// Token: 0x04000034 RID: 52
		private const string TEXTURES_FOLDER = "textures";

		// Token: 0x04000035 RID: 53
		private AtlasTexturesProcessor _atlasTextures;
	}
}
