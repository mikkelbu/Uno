#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum LaunchQuerySupportType 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Uri,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		UriForResults,
		#endif
	}
	#endif
}
