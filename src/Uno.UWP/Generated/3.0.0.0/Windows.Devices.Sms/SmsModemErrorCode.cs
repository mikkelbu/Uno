#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sms
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum SmsModemErrorCode 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Other,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		MessagingNetworkError,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		SmsOperationNotSupportedByDevice,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		SmsServiceNotSupportedByNetwork,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DeviceFailure,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		MessageNotEncodedProperly,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		MessageTooLarge,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		DeviceNotReady,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		NetworkNotReady,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		InvalidSmscAddress,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		NetworkFailure,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		FixedDialingNumberRestricted,
		#endif
	}
	#endif
}
