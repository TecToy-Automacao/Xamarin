package mono.com.orbbec.astra;


public class StreamReader_FrameListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.orbbec.astra.StreamReader.FrameListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFrameReady:(Lcom/orbbec/astra/StreamReader;Lcom/orbbec/astra/ReaderFrame;)V:GetOnFrameReady_Lcom_orbbec_astra_StreamReader_Lcom_orbbec_astra_ReaderFrame_Handler:Com.Orbbec.Astra.StreamReader/IFrameListenerInvoker, Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Orbbec.Astra.StreamReader+IFrameListenerImplementor, Binding", StreamReader_FrameListenerImplementor.class, __md_methods);
	}


	public StreamReader_FrameListenerImplementor ()
	{
		super ();
		if (getClass () == StreamReader_FrameListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Com.Orbbec.Astra.StreamReader+IFrameListenerImplementor, Binding", "", this, new java.lang.Object[] {  });
		}
	}


	public void onFrameReady (com.orbbec.astra.StreamReader p0, com.orbbec.astra.ReaderFrame p1)
	{
		n_onFrameReady (p0, p1);
	}

	private native void n_onFrameReady (com.orbbec.astra.StreamReader p0, com.orbbec.astra.ReaderFrame p1);

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
