#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Authentication.Identity.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum MicrosoftAccountMultiFactorAuthenticationType 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		User,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Device,
		#endif
	}
	#endif
}