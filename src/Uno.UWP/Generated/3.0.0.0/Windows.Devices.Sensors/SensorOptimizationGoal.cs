#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum SensorOptimizationGoal 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Precision,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		PowerEfficiency,
		#endif
	}
	#endif
}