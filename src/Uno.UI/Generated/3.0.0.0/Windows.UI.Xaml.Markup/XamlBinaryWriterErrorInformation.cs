#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Markup
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct XamlBinaryWriterErrorInformation 
	{
		// Forced skipping of method Windows.UI.Xaml.Markup.XamlBinaryWriterErrorInformation.XamlBinaryWriterErrorInformation()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint InputStreamIndex;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint LineNumber;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint LinePosition;
		#endif
	}
}
