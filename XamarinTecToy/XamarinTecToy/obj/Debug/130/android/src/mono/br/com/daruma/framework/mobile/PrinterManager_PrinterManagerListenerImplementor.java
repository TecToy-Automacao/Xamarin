package mono.br.com.daruma.framework.mobile;


public class PrinterManager_PrinterManagerListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		br.com.daruma.framework.mobile.PrinterManager.PrinterManagerListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onServiceConnected:()V:GetOnServiceConnectedHandler:BR.Com.Daruma.Framework.Mobile.PrinterManager/IPrinterManagerListenerInvoker, Binding\n" +
			"";
		mono.android.Runtime.register ("BR.Com.Daruma.Framework.Mobile.PrinterManager+IPrinterManagerListenerImplementor, Binding", PrinterManager_PrinterManagerListenerImplementor.class, __md_methods);
	}


	public PrinterManager_PrinterManagerListenerImplementor ()
	{
		super ();
		if (getClass () == PrinterManager_PrinterManagerListenerImplementor.class) {
			mono.android.TypeManager.Activate ("BR.Com.Daruma.Framework.Mobile.PrinterManager+IPrinterManagerListenerImplementor, Binding", "", this, new java.lang.Object[] {  });
		}
	}


	public void onServiceConnected ()
	{
		n_onServiceConnected ();
	}

	private native void n_onServiceConnected ();

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
