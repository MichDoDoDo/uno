﻿#if !__APPLE_UIKIT__ && !__ANDROID__ && !UNO_REFERENCE_API
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	public partial class ItemsStackPanel : global::Microsoft.UI.Xaml.Controls.Panel
	{
		[Uno.NotImplemented]
		public ItemsStackPanel()
		{

		}
	}
}
#endif
