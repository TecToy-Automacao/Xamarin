package mono.com.orbbec.astra.android;


public class AstraDeviceManagerListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.orbbec.astra.android.AstraDeviceManagerListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onNoDevice:()V:GetOnNoDeviceHandler:Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerInvoker, Binding\n" +
			"n_onOpenAllDevicesCompleted:(Ljava/lang/Iterable;Ljava/lang/Iterable;)V:GetOnOpenAllDevicesCompleted_Ljava_lang_Iterable_Ljava_lang_Iterable_Handler:Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerInvoker, Binding\n" +
			"n_onOpenDeviceCompleted:(Landroid/hardware/usb/UsbDevice;Z)V:GetOnOpenDeviceCompleted_Landroid_hardware_usb_UsbDevice_ZHandler:Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerInvoker, Binding\n" +
			"n_onPermissionDenied:(Landroid/hardware/usb/UsbDevice;)V:GetOnPermissionDenied_Landroid_hardware_usb_UsbDevice_Handler:Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerInvoker, Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerImplementor, Binding", AstraDeviceManagerListenerImplementor.class, __md_methods);
	}


	public AstraDeviceManagerListenerImplementor ()
	{
		super ();
		if (getClass () == AstraDeviceManagerListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Orbbec.Astra.Android.IAstraDeviceManagerListenerImplementor, Binding", "", this, new java.lang.Object[] {  });
		}
	}


	public void onNoDevice ()
	{
		n_onNoDevice ();
	}

	private native void n_onNoDevice ();


	public void onOpenAllDevicesCompleted (java.lang.Iterable p0, java.lang.Iterable p1)
	{
		n_onOpenAllDevicesCompleted (p0, p1);
	}

	private native void n_onOpenAllDevicesCompleted (java.lang.Iterable p0, java.lang.Iterable p1);


	public void onOpenDeviceCompleted (android.hardware.usb.UsbDevice p0, boolean p1)
	{
		n_onOpenDeviceCompleted (p0, p1);
	}

	private native void n_onOpenDeviceCompleted (android.hardware.usb.UsbDevice p0, boolean p1);


	public void onPermissionDenied (android.hardware.usb.UsbDevice p0)
	{
		n_onPermissionDenied (p0);
	}

	private native void n_onPermissionDenied (android.hardware.usb.UsbDevice p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
