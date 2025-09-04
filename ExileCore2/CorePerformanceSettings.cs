using System;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Attributes;
using ExileCore2.Shared.Nodes;

namespace ExileCore2
{
	// Token: 0x02000029 RID: 41
	[Submenu]
	public class CorePerformanceSettings
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0016E148 File Offset: 0x0016E148
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0016E150 File Offset: 0x0016E150
		public RangeNode<int> EntityParserThreads
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0016E15C File Offset: 0x0016E15C
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0016E164 File Offset: 0x0016E164
		[Menu("Target FPS")]
		public RangeNode<int> TargetFps
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0016E170 File Offset: 0x0016E170
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0016E178 File Offset: 0x0016E178
		[Menu(null, "How often to update entities. You can see time spent on this in DebugWindow->Coroutines.")]
		public RangeNode<int> EntitiesFps
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0016E184 File Offset: 0x0016E184
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0016E18C File Offset: 0x0016E18C
		public ToggleNode ParseServerEntities
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0016E198 File Offset: 0x0016E198
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0016E1A0 File Offset: 0x0016E1A0
		[Menu("Limit draw plot in ms", "Don't put small value, because plot need a lot triangles and DebugWindow with a lot plot will be broke.")]
		public RangeNode<float> LimitDrawPlot
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0016E1AC File Offset: 0x0016E1AC
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0016E1B4 File Offset: 0x0016E1B4
		public RangeNode<int> MaxGroundItemLabels
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0016E1C0 File Offset: 0x0016E1C0
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0016E1C8 File Offset: 0x0016E1C8
		public RangeNode<int> MaxEntities
		{
			[CompilerGenerated]
			get
			{
				return this;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0016E1D4 File Offset: 0x0016E1D4
		public CorePerformanceSettings()
		{
			this;
			1;
			0;
			this;
			60;
			5;
			this;
			60;
			5;
			this;
			1;
			this;
			this;
			0;
			this;
			0;
			this;
		}
	}
}
