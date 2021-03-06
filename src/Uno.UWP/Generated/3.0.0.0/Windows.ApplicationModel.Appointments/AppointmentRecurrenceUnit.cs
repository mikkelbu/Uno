#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Appointments
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum AppointmentRecurrenceUnit 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Daily,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Weekly,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Monthly,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		MonthlyOnDay,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Yearly,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		YearlyOnDay,
		#endif
	}
	#endif
}
