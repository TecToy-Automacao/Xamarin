package mono.com.orbbec.astra.android;


public class UsbDeviceAccessBroker_UsbDeviceAccessEventListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.orbbec.astra.android.UsbDeviceAccessBroker.UsbDeviceAccessEventListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDeviceOpenFailed:(Landroid/hardware/usb/UsbDevice;)V:GetOnDeviceOpenFailed_Landroid_hardware_usb_UsbDevice_Handler:Com.Orbbec.Astra.Android.UsbDeviceAccessBroker/IUsbDeviceAccessEventListenerInvoker, Binding\n" +
			"n_onDeviceOpened:(Landroid/hardware/usb/UsbDevice;Landroid/hardware/usb/UsbDeviceConnection;)V:GetOnDeviceOpened_Landroid_hardware_usb_UsbDevice_Landroid_hardware_usb_UsbDeviceConnection_Handler:Com.Orbbec.Astra.Android.UsbDeviceAccessBroker/IUsbDeviceAccessEventListenerInvoker, Binding\n" +
			"n_onPermissionDenied:(Landroid/hardware/usb/UsbDevice;)V:GetOnPermissionDenied_Landroid_hardware_usb_UsbDevice_Handler:Com.Orbbec.Astra.Android.UsbDeviceAccessBroker/IUsbDeviceAccessEventListenerInvoker, Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Orbbec.Astra.Android.UsbDeviceAccessBroker+IUsbDeviceAccessEventListenerImplementor, Binding", UsbDeviceAccessBroker_UsbDeviceAccessEventListenerImplementor.class, __md_methods);
	}


	public UsbDeviceAccessBroker_UsbDeviceAccessEventListenerImplementor ()
	{
		super ();
		if (getClass () == UsbDeviceAccessBroker_UsbDeviceAccessEventListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Orbbec.Astra.Android.UsbDeviceAccessBroker+IUsbDeviceAccessEventListenerImplementor, Binding", "", this, new java.lang.Object[] {  });
		}
	}


	public void onDeviceOpenFailed (android.hardware.usb.UsbDevice p0)
	{
		n_onDeviceOpenFailed (p0);
	}

	private native void n_onDeviceOpenFailed (android.hardware.usb.UsbDevice p0);


	public void onDeviceOpened (android.hardware.usb.UsbDevice p0, android.hardware.usb.UsbDeviceConnection p1)
	{
		n_onDeviceOpened (p0, p1);
	}

	private native void n_onDeviceOpened (android.hardware.usb.UsbDevice p0, android.hardware.usb.UsbDeviceConnection p1);


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
