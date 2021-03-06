#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Provider
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IWindowProvider 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Xaml.Automation.WindowInteractionState InteractionState
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool IsModal
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool IsTopmost
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool Maximizable
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool Minimizable
		{
			get;
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::Windows.UI.Xaml.Automation.WindowVisualState VisualState
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IWindowProvider.IsModal.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IWindowProvider.IsTopmost.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IWindowProvider.Maximizable.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IWindowProvider.Minimizable.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IWindowProvider.InteractionState.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Provider.IWindowProvider.VisualState.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void Close();
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		void SetVisualState( global::Windows.UI.Xaml.Automation.WindowVisualState state);
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		bool WaitForInputIdle( int milliseconds);
		#endif
	}
}
