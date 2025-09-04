using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;
using ImGuiNET;

namespace ExileCore2.RenderQ
{
	// Token: 0x02000189 RID: 393
	public class ThemeConfig : ISettings
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00191350 File Offset: 0x00191350
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00191358 File Offset: 0x00191358
		public ToggleNode Enable
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

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00191364 File Offset: 0x00191364
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x0019136C File Offset: 0x0019136C
		public bool AntiAliasedLines
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00191378 File Offset: 0x00191378
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00191380 File Offset: 0x00191380
		public Vector2 DisplaySafeAreaPadding
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

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0019138C File Offset: 0x0019138C
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00191394 File Offset: 0x00191394
		public Vector2 DisplayWindowPadding
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

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x001913A0 File Offset: 0x001913A0
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x001913A8 File Offset: 0x001913A8
		public float GrabRounding
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

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x001913B4 File Offset: 0x001913B4
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x001913BC File Offset: 0x001913BC
		public float GrabMinSize
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x001913C8 File Offset: 0x001913C8
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x001913D0 File Offset: 0x001913D0
		public float ScrollbarRounding
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x001913DC File Offset: 0x001913DC
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x001913E4 File Offset: 0x001913E4
		public float ScrollbarSize
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

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x001913F0 File Offset: 0x001913F0
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x001913F8 File Offset: 0x001913F8
		public float ColumnsMinSpacing
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00191404 File Offset: 0x00191404
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x0019140C File Offset: 0x0019140C
		public float IndentSpacing
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

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00191418 File Offset: 0x00191418
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00191420 File Offset: 0x00191420
		public Vector2 TouchExtraPadding
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0019142C File Offset: 0x0019142C
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00191434 File Offset: 0x00191434
		public Vector2 ItemInnerSpacing
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

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00191440 File Offset: 0x00191440
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00191448 File Offset: 0x00191448
		public Vector2 ItemSpacing
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00191454 File Offset: 0x00191454
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0019145C File Offset: 0x0019145C
		public float FrameRounding
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

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00191468 File Offset: 0x00191468
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00191470 File Offset: 0x00191470
		public Vector2 FramePadding
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

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0019147C File Offset: 0x0019147C
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00191484 File Offset: 0x00191484
		public float ChildWindowRounding
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

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00191490 File Offset: 0x00191490
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00191498 File Offset: 0x00191498
		public Vector2 WindowTitleAlign
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

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x001914A4 File Offset: 0x001914A4
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x001914AC File Offset: 0x001914AC
		public float WindowRounding
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

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x001914B8 File Offset: 0x001914B8
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x001914C0 File Offset: 0x001914C0
		public Vector2 WindowPadding
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

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x001914CC File Offset: 0x001914CC
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x001914D4 File Offset: 0x001914D4
		public float Alpha
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x001914E0 File Offset: 0x001914E0
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x001914E8 File Offset: 0x001914E8
		public bool AntiAliasedFill
		{
			[CompilerGenerated]
			get
			{
				return this != null;
			}
			[CompilerGenerated]
			set
			{
				this;
				value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x001914F4 File Offset: 0x001914F4
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x001914FC File Offset: 0x001914FC
		public float CurveTessellationTolerance
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

		// Token: 0x06000A6E RID: 2670 RVA: 0x00191508 File Offset: 0x00191508
		public ThemeConfig()
		{
			this;
			this;
			1;
			this;
			1;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			this;
			1;
			this;
			this;
		}

		// Token: 0x04007DE0 RID: 32224
		public Dictionary<ImGuiCol, Vector4> Colors;
	}
}
