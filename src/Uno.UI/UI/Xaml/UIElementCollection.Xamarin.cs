﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Uno.Extensions;
using System;
using Uno.UI.Controls;
#if __ANDROID__
using _View = Android.Views.View;
using _BindableView = Uno.UI.Controls.BindableView;
#elif __APPLE_UIKIT__
using _View = UIKit.UIView;
using _BindableView = Uno.UI.Controls.BindableUIView;
#endif

namespace Microsoft.UI.Xaml.Controls
{
	public partial class UIElementCollection : IList<UIElement>, IEnumerable<UIElement>
	{

		// This method is present to enable allocation-less enumeration.
		public Enumerator GetEnumerator() => new Enumerator(_owner);

		IEnumerator<UIElement> IEnumerable<UIElement>.GetEnumerator() => GetEnumerator();

		public struct Enumerator : IEnumerator<UIElement>, IEnumerator
		{
			private List<_View>.Enumerator _inner;

			internal Enumerator(_BindableView owner)
			{
				_inner = owner.GetChildrenEnumerator();
			}

			public UIElement Current => _inner.Current as UIElement;

			object IEnumerator.Current => Current;

			public void Dispose() => _inner.Dispose();

			public bool MoveNext() => _inner.MoveNext();

			public void Reset() => ((IEnumerator)_inner).Reset();
		}
	}
}
