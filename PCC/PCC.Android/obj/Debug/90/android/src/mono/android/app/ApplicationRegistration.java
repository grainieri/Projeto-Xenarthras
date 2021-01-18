package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("PCC.Droid.MainApplication, PCC.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc64acf3d4ca292adbec.MainApplication.class, crc64acf3d4ca292adbec.MainApplication.__md_methods);
		
	}
}
