namespace Windows.UI.ViewManagement
{
	public  partial class UISettings 
	{
		public  bool AnimationsEnabled
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "AnimationsEnabled");
#if __WASM__
				return false;
#else
				return true;
#endif
			}
		}

		public  uint CaretBlinkRate
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "CaretBlinkRate");
				return 1;
			}
		}

		public  bool CaretBrowsingEnabled
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "CaretBrowsingEnabled");
				return false;
			}
		}

		public  uint CaretWidth
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "CaretWidth");
				return 1;
			}
		}

		public  global::Windows.Foundation.Size CursorSize
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "CaretWidth");
				return new Foundation.Size(1, 10);
			}
		}

		public  uint DoubleClickTime
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "DoubleClickTime");
				return 250;
			}
		}

		public  global::Windows.UI.ViewManagement.HandPreference HandPreference
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "HandPreference");
				return global::Windows.UI.ViewManagement.HandPreference.RightHanded;
			}
		}

		public  uint MessageDuration
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "MessageDuration");
				return 0;
			}
		}

		public  uint MouseHoverTime
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "MouseHoverTime");
				return 0;
			}
		}

		public  global::Windows.Foundation.Size ScrollBarArrowSize
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "ScrollBarArrowSize");
				return new Foundation.Size(10, 10);
			}
		}

		public  global::Windows.Foundation.Size ScrollBarSize
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "ScrollBarSize");
				return new Foundation.Size(10, 10);
			}
		}

		public  global::Windows.Foundation.Size ScrollBarThumbBoxSize
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "ScrollBarThumbBoxSize");
				return new Foundation.Size(10, 10);
			}
		}

		public  double TextScaleFactor
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "TextScaleFactor");
				return 1;
			}
		}

		public  bool AdvancedEffectsEnabled
		{
			get
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "AdvancedEffectsEnabled");
				return true;
			}
		}

		public UISettings() 
		{

		}

		public  global::Windows.UI.Color UIElementColor( global::Windows.UI.ViewManagement.UIElementType desiredElement)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "UIElementColor");
			return Colors.Black;
		}

		public global::Windows.UI.Color GetColorValue(global::Windows.UI.ViewManagement.UIColorType desiredColor)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.UISettings", "GetColorValue");
			return Colors.Black;
		}

#pragma warning disable 67
		[global::Uno.NotImplemented]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.UISettings, object> TextScaleFactorChanged;

		[global::Uno.NotImplemented]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.UISettings, object> ColorValuesChanged;

		[global::Uno.NotImplemented]
		public event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.ViewManagement.UISettings, object> AdvancedEffectsEnabledChanged;
#pragma warning restore 67
	}
}
