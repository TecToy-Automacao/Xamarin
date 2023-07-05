package mono.br.com.daruma.framework.mobile.log.listeners;


public class ITraceListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		br.com.daruma.framework.mobile.log.listeners.ITraceListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_check:(ILjava/lang/String;)Z:GetCheck_ILjava_lang_String_Handler:BR.Com.Daruma.Framework.Mobile.Log.Listeners.ITraceListenerInvoker, Binding\n" +
			"n_traceOcurred:(ILjava/lang/String;Ljava/lang/String;Ljava/util/Date;)V:GetTraceOcurred_ILjava_lang_String_Ljava_lang_String_Ljava_util_Date_Handler:BR.Com.Daruma.Framework.Mobile.Log.Listeners.ITraceListenerInvoker, Binding\n" +
			"";
		mono.android.Runtime.register ("BR.Com.Daruma.Framework.Mobile.Log.Listeners.ITraceListenerImplementor, Binding", ITraceListenerImplementor.class, __md_methods);
	}


	public ITraceListenerImplementor ()
	{
		super ();
		if (getClass () == ITraceListenerImplementor.class) {
			mono.android.TypeManager.Activate ("BR.Com.Daruma.Framework.Mobile.Log.Listeners.ITraceListenerImplementor, Binding", "", this, new java.lang.Object[] {  });
		}
	}


	public boolean check (int p0, java.lang.String p1)
	{
		return n_check (p0, p1);
	}

	private native boolean n_check (int p0, java.lang.String p1);


	public void traceOcurred (int p0, java.lang.String p1, java.lang.String p2, java.util.Date p3)
	{
		n_traceOcurred (p0, p1, p2, p3);
	}

	private native void n_traceOcurred (int p0, java.lang.String p1, java.lang.String p2, java.util.Date p3);

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
