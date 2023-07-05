using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace BR.Com.Itfast.Tectoy.Service {

	// Metadata.xml XPath interface reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']"
	[Register ("br/com/itfast/tectoy/service/TecToyServices", "", "BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker")]
	public partial interface ITecToyServices : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='abrirGaveta' and count(parameter)=0]"
		[Register ("abrirGaveta", "()V", "GetAbrirGavetaHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void AbrirGaveta ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='acionarGuilhotina' and count(parameter)=0]"
		[Register ("acionarGuilhotina", "()V", "GetAcionarGuilhotinaHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void AcionarGuilhotina ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='beep' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("beep", "(I)I", "GetBeep_IHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int Beep (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='bmpDisplay' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("bmpDisplay", "(Landroid/graphics/Bitmap;)V", "GetBmpDisplay_Landroid_graphics_Bitmap_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void BmpDisplay (global::Android.Graphics.Bitmap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='cadProdutoBalanca' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("cadProdutoBalanca", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetCadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void CadProdutoBalanca (string p0, string p1, string p2, string p3, string p4, string p5, string p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='cadastrarImagemBiometria' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("cadastrarImagemBiometria", "(Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;)V", "GetCadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void CadastrarImagemBiometria (global::Android.Graphics.Bitmap p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='configLeitor' and count(parameter)=0]"
		[Register ("configLeitor", "()V", "GetConfigLeitorHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void ConfigLeitor ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='dataHoraBalanca' and count(parameter)=0]"
		[Register ("dataHoraBalanca", "()Ljava/lang/String;", "GetDataHoraBalancaHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		string DataHoraBalanca ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='desligarLedStatus' and count(parameter)=0]"
		[Register ("desligarLedStatus", "()V", "GetDesligarLedStatusHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void DesligarLedStatus ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='enviarImagemBiometria' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='br.com.itfast.tectoy.TecToyReconhecimentoFacialCallback']]"
		[Register ("enviarImagemBiometria", "(Landroid/graphics/Bitmap;Lbr/com/itfast/tectoy/TecToyReconhecimentoFacialCallback;)V", "GetEnviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void EnviarImagemBiometria (global::Android.Graphics.Bitmap p0, global::BR.Com.Itfast.Tectoy.ITecToyReconhecimentoFacialCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='escreveDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escreveDisplay", "(Ljava/lang/String;)V", "GetEscreveDisplay_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void EscreveDisplay (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='escreveDisplay' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("escreveDisplay", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEscreveDisplay_Ljava_lang_String_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void EscreveDisplay (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='escreverNFC' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escreverNFC", "(Ljava/lang/String;)V", "GetEscreverNFC_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void EscreverNFC (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='finalEtiqueta' and count(parameter)=0]"
		[Register ("finalEtiqueta", "()V", "GetFinalEtiquetaHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void FinalEtiqueta ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='gavetaAberta' and count(parameter)=0]"
		[Register ("gavetaAberta", "()Z", "GetGavetaAbertaHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		bool GavetaAberta ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='getCPUCardState' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getCPUCardState", "([B)I", "GetGetCPUCardState_arrayBHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int GetCPUCardState (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='getEMID' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("getEMID", "([B[B)I", "GetGetEMID_arrayBarrayBHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int GetEMID (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='imprimir' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("imprimir", "([B)Z", "GetImprimir_arrayBHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		bool Imprimir (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='imprimir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("imprimir", "(Ljava/lang/String;)Z", "GetImprimir_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		bool Imprimir (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='imprimirBMP' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("imprimirBMP", "(Ljava/lang/String;)V", "GetImprimirBMP_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void ImprimirBMP (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='imprimirImagem' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("imprimirImagem", "(Landroid/graphics/Bitmap;)Z", "GetImprimirImagem_Landroid_graphics_Bitmap_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		bool ImprimirImagem (global::Android.Graphics.Bitmap p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='imprimirQrCode' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("imprimirQrCode", "(Ljava/lang/String;Ljava/lang/String;I)V", "GetImprimirQrCode_Ljava_lang_String_Ljava_lang_String_IHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void ImprimirQrCode (string p0, string p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='iniciarBalanca' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("iniciarBalanca", "(Ljava/lang/String;Ljava/lang/String;)V", "GetIniciarBalanca_Ljava_lang_String_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void IniciarBalanca (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='iniciarCameraProfundidade' and count(parameter)=1 and parameter[1][@type='br.com.itfast.tectoy.TecToyCameraProfundidadeCallback']]"
		[Register ("iniciarCameraProfundidade", "(Lbr/com/itfast/tectoy/TecToyCameraProfundidadeCallback;)V", "GetIniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void IniciarCameraProfundidade (global::BR.Com.Itfast.Tectoy.ITecToyCameraProfundidadeCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='iniciarNFC' and count(parameter)=0]"
		[Register ("iniciarNFC", "()V", "GetIniciarNFCHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void IniciarNFC ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='iniciarNFC' and count(parameter)=2 and parameter[1][@type='br.com.itfast.tectoy.TecToyNfcCallback'] and parameter[2][@type='android.content.Intent']]"
		[Register ("iniciarNFC", "(Lbr/com/itfast/tectoy/TecToyNfcCallback;Landroid/content/Intent;)V", "GetIniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void IniciarNFC (global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback p0, global::Android.Content.Intent p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='iniciarScanner' and count(parameter)=1 and parameter[1][@type='br.com.itfast.tectoy.TecToyScannerCallback']]"
		[Register ("iniciarScanner", "(Lbr/com/itfast/tectoy/TecToyScannerCallback;)V", "GetIniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void IniciarScanner (global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='lerPeso' and count(parameter)=1 and parameter[1][@type='br.com.itfast.tectoy.TectoyBalancaCallback']]"
		[Register ("lerPeso", "(Lbr/com/itfast/tectoy/TectoyBalancaCallback;)V", "GetLerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void LerPeso (global::BR.Com.Itfast.Tectoy.ITectoyBalancaCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='ligarLedStatus' and count(parameter)=1 and parameter[1][@type='br.com.itfast.tectoy.CorLed']]"
		[Register ("ligarLedStatus", "(Lbr/com/itfast/tectoy/CorLed;)V", "GetLigarLedStatus_Lbr_com_itfast_tectoy_CorLed_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void LigarLedStatus (global::BR.Com.Itfast.Tectoy.CorLed p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='limparDisplay' and count(parameter)=0]"
		[Register ("limparDisplay", "()V", "GetLimparDisplayHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void LimparDisplay ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='loopLigarStatus' and count(parameter)=2 and parameter[1][@type='br.com.itfast.tectoy.CorLed'] and parameter[2][@type='int']]"
		[Register ("loopLigarStatus", "(Lbr/com/itfast/tectoy/CorLed;I)V", "GetLoopLigarStatus_Lbr_com_itfast_tectoy_CorLed_IHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void LoopLigarStatus (global::BR.Com.Itfast.Tectoy.CorLed p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='macBalanca' and count(parameter)=0]"
		[Register ("macBalanca", "()Ljava/lang/String;", "GetMacBalancaHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		string MacBalanca ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='modeloScanner' and count(parameter)=0]"
		[Register ("modeloScanner", "()Ljava/lang/String;", "GetModeloScannerHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		string ModeloScanner ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='newIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("newIntent", "(Landroid/content/Intent;)V", "GetNewIntent_Landroid_content_Intent_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void NewIntent (global::Android.Content.Intent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onPause", "(Landroid/app/Activity;)V", "GetOnPause_Landroid_app_Activity_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void OnPause (global::Android.App.Activity p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='onResume' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.app.PendingIntent']]"
		[Register ("onResume", "(Landroid/app/Activity;Landroid/app/PendingIntent;)V", "GetOnResume_Landroid_app_Activity_Landroid_app_PendingIntent_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void OnResume (global::Android.App.Activity p0, global::Android.App.PendingIntent p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='pararScanner' and count(parameter)=0]"
		[Register ("pararScanner", "()V", "GetPararScannerHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void PararScanner ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='posicionarEtiqueta' and count(parameter)=0]"
		[Register ("posicionarEtiqueta", "()V", "GetPosicionarEtiquetaHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void PosicionarEtiqueta ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='qrCodeDisplay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("qrCodeDisplay", "(Ljava/lang/String;)V", "GetQrCodeDisplay_Ljava_lang_String_Handler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		void QrCodeDisplay (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='readNAN' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("readNAN", "(I[B[B[B)I", "GetReadNAN_IarrayBarrayBarrayBHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int ReadNAN (int p0, byte[] p1, byte[] p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='readSBInfo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("readSBInfo", "([B[B)I", "GetReadSBInfo_arrayBarrayBHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int ReadSBInfo (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='rfAuthEntication' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfAuthEntication", "(I[B)I", "GetRfAuthEntication_IarrayBHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int RfAuthEntication (int p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='rfCard' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("rfCard", "([B[B)I", "GetRfCard_arrayBarrayBHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int RfCard (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='rfDecrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfDecrement", "(II)I", "GetRfDecrement_IIHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int RfDecrement (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='rfIncrement' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfIncrement", "(II)I", "GetRfIncrement_IIHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int RfIncrement (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='rfInitVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rfInitVal", "(II)I", "GetRfInitVal_IIHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int RfInitVal (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='rfRead' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfRead", "(I[B)I", "GetRfRead_IarrayBHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int RfRead (int p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='rfReadVal' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("rfReadVal", "(I[I)I", "GetRfReadVal_IarrayIHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int RfReadVal (int p0, int[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='rfWrite' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("rfWrite", "(I[B)I", "GetRfWrite_IarrayBHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int RfWrite (int p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='rfhalt' and count(parameter)=0]"
		[Register ("rfhalt", "()I", "GetRfhaltHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		int Rfhalt ();

		// Metadata.xml XPath method reference: path="/api/package[@name='br.com.itfast.tectoy.service']/interface[@name='TecToyServices']/method[@name='statusImpressora' and count(parameter)=0]"
		[Register ("statusImpressora", "()Lbr/com/itfast/tectoy/StatusImpressora;", "GetStatusImpressoraHandler:BR.Com.Itfast.Tectoy.Service.ITecToyServicesInvoker, Binding")]
		global::BR.Com.Itfast.Tectoy.StatusImpressora StatusImpressora ();

	}

	[global::Android.Runtime.Register ("br/com/itfast/tectoy/service/TecToyServices", DoNotGenerateAcw=true)]
	internal partial class ITecToyServicesInvoker : global::Java.Lang.Object, ITecToyServices {
		static readonly JniPeerMembers _members = new XAPeerMembers ("br/com/itfast/tectoy/service/TecToyServices", typeof (ITecToyServicesInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITecToyServices GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITecToyServices> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'br.com.itfast.tectoy.service.TecToyServices'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITecToyServicesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_abrirGaveta;
#pragma warning disable 0169
		static Delegate GetAbrirGavetaHandler ()
		{
			if (cb_abrirGaveta == null)
				cb_abrirGaveta = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_AbrirGaveta));
			return cb_abrirGaveta;
		}

		static void n_AbrirGaveta (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbrirGaveta ();
		}
#pragma warning restore 0169

		IntPtr id_abrirGaveta;
		public unsafe void AbrirGaveta ()
		{
			if (id_abrirGaveta == IntPtr.Zero)
				id_abrirGaveta = JNIEnv.GetMethodID (class_ref, "abrirGaveta", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abrirGaveta);
		}

		static Delegate cb_acionarGuilhotina;
#pragma warning disable 0169
		static Delegate GetAcionarGuilhotinaHandler ()
		{
			if (cb_acionarGuilhotina == null)
				cb_acionarGuilhotina = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_AcionarGuilhotina));
			return cb_acionarGuilhotina;
		}

		static void n_AcionarGuilhotina (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AcionarGuilhotina ();
		}
#pragma warning restore 0169

		IntPtr id_acionarGuilhotina;
		public unsafe void AcionarGuilhotina ()
		{
			if (id_acionarGuilhotina == IntPtr.Zero)
				id_acionarGuilhotina = JNIEnv.GetMethodID (class_ref, "acionarGuilhotina", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_acionarGuilhotina);
		}

		static Delegate cb_beep_I;
#pragma warning disable 0169
		static Delegate GetBeep_IHandler ()
		{
			if (cb_beep_I == null)
				cb_beep_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPI_I (n_Beep_I));
			return cb_beep_I;
		}

		static int n_Beep_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Beep (p0);
		}
#pragma warning restore 0169

		IntPtr id_beep_I;
		public unsafe int Beep (int p0)
		{
			if (id_beep_I == IntPtr.Zero)
				id_beep_I = JNIEnv.GetMethodID (class_ref, "beep", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_beep_I, __args);
		}

		static Delegate cb_bmpDisplay_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetBmpDisplay_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_bmpDisplay_Landroid_graphics_Bitmap_ == null)
				cb_bmpDisplay_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_BmpDisplay_Landroid_graphics_Bitmap_));
			return cb_bmpDisplay_Landroid_graphics_Bitmap_;
		}

		static void n_BmpDisplay_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BmpDisplay (p0);
		}
#pragma warning restore 0169

		IntPtr id_bmpDisplay_Landroid_graphics_Bitmap_;
		public unsafe void BmpDisplay (global::Android.Graphics.Bitmap p0)
		{
			if (id_bmpDisplay_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_bmpDisplay_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "bmpDisplay", "(Landroid/graphics/Bitmap;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bmpDisplay_Landroid_graphics_Bitmap_, __args);
		}

		static Delegate cb_cadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_cadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_cadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLLL_V (n_CadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_));
			return cb_cadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			var p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.CadProdutoBalanca (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		IntPtr id_cadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void CadProdutoBalanca (string p0, string p1, string p2, string p3, string p4, string p5, string p6)
		{
			if (id_cadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_cadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cadProdutoBalanca", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			IntPtr native_p3 = JNIEnv.NewString ((string)p3);
			IntPtr native_p4 = JNIEnv.NewString ((string)p4);
			IntPtr native_p5 = JNIEnv.NewString ((string)p5);
			IntPtr native_p6 = JNIEnv.NewString ((string)p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cadProdutoBalanca_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
		}

		static Delegate cb_cadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_cadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_cadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_CadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_));
			return cb_cadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_CadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CadastrarImagemBiometria (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_cadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void CadastrarImagemBiometria (global::Android.Graphics.Bitmap p0, string p1, string p2)
		{
			if (id_cadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_cadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "cadastrarImagemBiometria", "(Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			IntPtr native_p2 = JNIEnv.NewString ((string)p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cadastrarImagemBiometria_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_configLeitor;
#pragma warning disable 0169
		static Delegate GetConfigLeitorHandler ()
		{
			if (cb_configLeitor == null)
				cb_configLeitor = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ConfigLeitor));
			return cb_configLeitor;
		}

		static void n_ConfigLeitor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConfigLeitor ();
		}
#pragma warning restore 0169

		IntPtr id_configLeitor;
		public unsafe void ConfigLeitor ()
		{
			if (id_configLeitor == IntPtr.Zero)
				id_configLeitor = JNIEnv.GetMethodID (class_ref, "configLeitor", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configLeitor);
		}

		static Delegate cb_dataHoraBalanca;
#pragma warning disable 0169
		static Delegate GetDataHoraBalancaHandler ()
		{
			if (cb_dataHoraBalanca == null)
				cb_dataHoraBalanca = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_DataHoraBalanca));
			return cb_dataHoraBalanca;
		}

		static IntPtr n_DataHoraBalanca (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DataHoraBalanca ());
		}
#pragma warning restore 0169

		IntPtr id_dataHoraBalanca;
		public unsafe string DataHoraBalanca ()
		{
			if (id_dataHoraBalanca == IntPtr.Zero)
				id_dataHoraBalanca = JNIEnv.GetMethodID (class_ref, "dataHoraBalanca", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dataHoraBalanca), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_desligarLedStatus;
#pragma warning disable 0169
		static Delegate GetDesligarLedStatusHandler ()
		{
			if (cb_desligarLedStatus == null)
				cb_desligarLedStatus = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_DesligarLedStatus));
			return cb_desligarLedStatus;
		}

		static void n_DesligarLedStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DesligarLedStatus ();
		}
#pragma warning restore 0169

		IntPtr id_desligarLedStatus;
		public unsafe void DesligarLedStatus ()
		{
			if (id_desligarLedStatus == IntPtr.Zero)
				id_desligarLedStatus = JNIEnv.GetMethodID (class_ref, "desligarLedStatus", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_desligarLedStatus);
		}

		static Delegate cb_enviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_;
#pragma warning disable 0169
		static Delegate GetEnviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_Handler ()
		{
			if (cb_enviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_ == null)
				cb_enviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_EnviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_));
			return cb_enviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_;
		}

		static void n_EnviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::BR.Com.Itfast.Tectoy.ITecToyReconhecimentoFacialCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyReconhecimentoFacialCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EnviarImagemBiometria (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_enviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_;
		public unsafe void EnviarImagemBiometria (global::Android.Graphics.Bitmap p0, global::BR.Com.Itfast.Tectoy.ITecToyReconhecimentoFacialCallback p1)
		{
			if (id_enviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_ == IntPtr.Zero)
				id_enviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_ = JNIEnv.GetMethodID (class_ref, "enviarImagemBiometria", "(Landroid/graphics/Bitmap;Lbr/com/itfast/tectoy/TecToyReconhecimentoFacialCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enviarImagemBiometria_Landroid_graphics_Bitmap_Lbr_com_itfast_tectoy_TecToyReconhecimentoFacialCallback_, __args);
		}

		static Delegate cb_escreveDisplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreveDisplay_Ljava_lang_String_Handler ()
		{
			if (cb_escreveDisplay_Ljava_lang_String_ == null)
				cb_escreveDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EscreveDisplay_Ljava_lang_String_));
			return cb_escreveDisplay_Ljava_lang_String_;
		}

		static void n_EscreveDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EscreveDisplay (p0);
		}
#pragma warning restore 0169

		IntPtr id_escreveDisplay_Ljava_lang_String_;
		public unsafe void EscreveDisplay (string p0)
		{
			if (id_escreveDisplay_Ljava_lang_String_ == IntPtr.Zero)
				id_escreveDisplay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "escreveDisplay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_escreveDisplay_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreveDisplay_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_EscreveDisplay_Ljava_lang_String_Ljava_lang_String_));
			return cb_escreveDisplay_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_EscreveDisplay_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EscreveDisplay (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_escreveDisplay_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void EscreveDisplay (string p0, string p1)
		{
			if (id_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_escreveDisplay_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "escreveDisplay", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_escreveDisplay_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_escreverNFC_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscreverNFC_Ljava_lang_String_Handler ()
		{
			if (cb_escreverNFC_Ljava_lang_String_ == null)
				cb_escreverNFC_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_EscreverNFC_Ljava_lang_String_));
			return cb_escreverNFC_Ljava_lang_String_;
		}

		static void n_EscreverNFC_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EscreverNFC (p0);
		}
#pragma warning restore 0169

		IntPtr id_escreverNFC_Ljava_lang_String_;
		public unsafe void EscreverNFC (string p0)
		{
			if (id_escreverNFC_Ljava_lang_String_ == IntPtr.Zero)
				id_escreverNFC_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "escreverNFC", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_escreverNFC_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_finalEtiqueta;
#pragma warning disable 0169
		static Delegate GetFinalEtiquetaHandler ()
		{
			if (cb_finalEtiqueta == null)
				cb_finalEtiqueta = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_FinalEtiqueta));
			return cb_finalEtiqueta;
		}

		static void n_FinalEtiqueta (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinalEtiqueta ();
		}
#pragma warning restore 0169

		IntPtr id_finalEtiqueta;
		public unsafe void FinalEtiqueta ()
		{
			if (id_finalEtiqueta == IntPtr.Zero)
				id_finalEtiqueta = JNIEnv.GetMethodID (class_ref, "finalEtiqueta", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finalEtiqueta);
		}

		static Delegate cb_gavetaAberta;
#pragma warning disable 0169
		static Delegate GetGavetaAbertaHandler ()
		{
			if (cb_gavetaAberta == null)
				cb_gavetaAberta = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_GavetaAberta));
			return cb_gavetaAberta;
		}

		static bool n_GavetaAberta (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GavetaAberta ();
		}
#pragma warning restore 0169

		IntPtr id_gavetaAberta;
		public unsafe bool GavetaAberta ()
		{
			if (id_gavetaAberta == IntPtr.Zero)
				id_gavetaAberta = JNIEnv.GetMethodID (class_ref, "gavetaAberta", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_gavetaAberta);
		}

		static Delegate cb_getCPUCardState_arrayB;
#pragma warning disable 0169
		static Delegate GetGetCPUCardState_arrayBHandler ()
		{
			if (cb_getCPUCardState_arrayB == null)
				cb_getCPUCardState_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_I (n_GetCPUCardState_arrayB));
			return cb_getCPUCardState_arrayB;
		}

		static int n_GetCPUCardState_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetCPUCardState (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCPUCardState_arrayB;
		public unsafe int GetCPUCardState (byte[] p0)
		{
			if (id_getCPUCardState_arrayB == IntPtr.Zero)
				id_getCPUCardState_arrayB = JNIEnv.GetMethodID (class_ref, "getCPUCardState", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCPUCardState_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getEMID_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetGetEMID_arrayBarrayBHandler ()
		{
			if (cb_getEMID_arrayBarrayB == null)
				cb_getEMID_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_GetEMID_arrayBarrayB));
			return cb_getEMID_arrayBarrayB;
		}

		static int n_GetEMID_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetEMID (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getEMID_arrayBarrayB;
		public unsafe int GetEMID (byte[] p0, byte[] p1)
		{
			if (id_getEMID_arrayBarrayB == IntPtr.Zero)
				id_getEMID_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "getEMID", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEMID_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_imprimir_arrayB;
#pragma warning disable 0169
		static Delegate GetImprimir_arrayBHandler ()
		{
			if (cb_imprimir_arrayB == null)
				cb_imprimir_arrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_Imprimir_arrayB));
			return cb_imprimir_arrayB;
		}

		static bool n_Imprimir_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Imprimir (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_imprimir_arrayB;
		public unsafe bool Imprimir (byte[] p0)
		{
			if (id_imprimir_arrayB == IntPtr.Zero)
				id_imprimir_arrayB = JNIEnv.GetMethodID (class_ref, "imprimir", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_imprimir_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_imprimir_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImprimir_Ljava_lang_String_Handler ()
		{
			if (cb_imprimir_Ljava_lang_String_ == null)
				cb_imprimir_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_Imprimir_Ljava_lang_String_));
			return cb_imprimir_Ljava_lang_String_;
		}

		static bool n_Imprimir_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Imprimir (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_imprimir_Ljava_lang_String_;
		public unsafe bool Imprimir (string p0)
		{
			if (id_imprimir_Ljava_lang_String_ == IntPtr.Zero)
				id_imprimir_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "imprimir", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_imprimir_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_imprimirBMP_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImprimirBMP_Ljava_lang_String_Handler ()
		{
			if (cb_imprimirBMP_Ljava_lang_String_ == null)
				cb_imprimirBMP_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_ImprimirBMP_Ljava_lang_String_));
			return cb_imprimirBMP_Ljava_lang_String_;
		}

		static void n_ImprimirBMP_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImprimirBMP (p0);
		}
#pragma warning restore 0169

		IntPtr id_imprimirBMP_Ljava_lang_String_;
		public unsafe void ImprimirBMP (string p0)
		{
			if (id_imprimirBMP_Ljava_lang_String_ == IntPtr.Zero)
				id_imprimirBMP_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "imprimirBMP", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_imprimirBMP_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_imprimirImagem_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetImprimirImagem_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_imprimirImagem_Landroid_graphics_Bitmap_ == null)
				cb_imprimirImagem_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_Z (n_ImprimirImagem_Landroid_graphics_Bitmap_));
			return cb_imprimirImagem_Landroid_graphics_Bitmap_;
		}

		static bool n_ImprimirImagem_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ImprimirImagem (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_imprimirImagem_Landroid_graphics_Bitmap_;
		public unsafe bool ImprimirImagem (global::Android.Graphics.Bitmap p0)
		{
			if (id_imprimirImagem_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_imprimirImagem_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "imprimirImagem", "(Landroid/graphics/Bitmap;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_imprimirImagem_Landroid_graphics_Bitmap_, __args);
			return __ret;
		}

		static Delegate cb_imprimirQrCode_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetImprimirQrCode_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_imprimirQrCode_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_imprimirQrCode_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLI_V (n_ImprimirQrCode_Ljava_lang_String_Ljava_lang_String_I));
			return cb_imprimirQrCode_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_ImprimirQrCode_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ImprimirQrCode (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_imprimirQrCode_Ljava_lang_String_Ljava_lang_String_I;
		public unsafe void ImprimirQrCode (string p0, string p1, int p2)
		{
			if (id_imprimirQrCode_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_imprimirQrCode_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "imprimirQrCode", "(Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_imprimirQrCode_Ljava_lang_String_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_iniciarBalanca_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIniciarBalanca_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_iniciarBalanca_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_iniciarBalanca_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_IniciarBalanca_Ljava_lang_String_Ljava_lang_String_));
			return cb_iniciarBalanca_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_IniciarBalanca_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.IniciarBalanca (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_iniciarBalanca_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void IniciarBalanca (string p0, string p1)
		{
			if (id_iniciarBalanca_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_iniciarBalanca_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "iniciarBalanca", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			IntPtr native_p1 = JNIEnv.NewString ((string)p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iniciarBalanca_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_iniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_;
#pragma warning disable 0169
		static Delegate GetIniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_Handler ()
		{
			if (cb_iniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_ == null)
				cb_iniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_IniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_));
			return cb_iniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_;
		}

		static void n_IniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::BR.Com.Itfast.Tectoy.ITecToyCameraProfundidadeCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyCameraProfundidadeCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IniciarCameraProfundidade (p0);
		}
#pragma warning restore 0169

		IntPtr id_iniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_;
		public unsafe void IniciarCameraProfundidade (global::BR.Com.Itfast.Tectoy.ITecToyCameraProfundidadeCallback p0)
		{
			if (id_iniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_ == IntPtr.Zero)
				id_iniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_ = JNIEnv.GetMethodID (class_ref, "iniciarCameraProfundidade", "(Lbr/com/itfast/tectoy/TecToyCameraProfundidadeCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iniciarCameraProfundidade_Lbr_com_itfast_tectoy_TecToyCameraProfundidadeCallback_, __args);
		}

		static Delegate cb_iniciarNFC;
#pragma warning disable 0169
		static Delegate GetIniciarNFCHandler ()
		{
			if (cb_iniciarNFC == null)
				cb_iniciarNFC = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_IniciarNFC));
			return cb_iniciarNFC;
		}

		static void n_IniciarNFC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IniciarNFC ();
		}
#pragma warning restore 0169

		IntPtr id_iniciarNFC;
		public unsafe void IniciarNFC ()
		{
			if (id_iniciarNFC == IntPtr.Zero)
				id_iniciarNFC = JNIEnv.GetMethodID (class_ref, "iniciarNFC", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iniciarNFC);
		}

		static Delegate cb_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetIniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_Handler ()
		{
			if (cb_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ == null)
				cb_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_IniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_));
			return cb_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_;
		}

		static void n_IniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.IniciarNFC (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_;
		public unsafe void IniciarNFC (global::BR.Com.Itfast.Tectoy.ITecToyNfcCallback p0, global::Android.Content.Intent p1)
		{
			if (id_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ == IntPtr.Zero)
				id_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "iniciarNFC", "(Lbr/com/itfast/tectoy/TecToyNfcCallback;Landroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iniciarNFC_Lbr_com_itfast_tectoy_TecToyNfcCallback_Landroid_content_Intent_, __args);
		}

		static Delegate cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_;
#pragma warning disable 0169
		static Delegate GetIniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_Handler ()
		{
			if (cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ == null)
				cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_IniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_));
			return cb_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_;
		}

		static void n_IniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IniciarScanner (p0);
		}
#pragma warning restore 0169

		IntPtr id_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_;
		public unsafe void IniciarScanner (global::BR.Com.Itfast.Tectoy.ITecToyScannerCallback p0)
		{
			if (id_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ == IntPtr.Zero)
				id_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_ = JNIEnv.GetMethodID (class_ref, "iniciarScanner", "(Lbr/com/itfast/tectoy/TecToyScannerCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_iniciarScanner_Lbr_com_itfast_tectoy_TecToyScannerCallback_, __args);
		}

		static Delegate cb_lerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_;
#pragma warning disable 0169
		static Delegate GetLerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_Handler ()
		{
			if (cb_lerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_ == null)
				cb_lerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_));
			return cb_lerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_;
		}

		static void n_LerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::BR.Com.Itfast.Tectoy.ITectoyBalancaCallback)global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.ITectoyBalancaCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LerPeso (p0);
		}
#pragma warning restore 0169

		IntPtr id_lerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_;
		public unsafe void LerPeso (global::BR.Com.Itfast.Tectoy.ITectoyBalancaCallback p0)
		{
			if (id_lerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_ == IntPtr.Zero)
				id_lerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_ = JNIEnv.GetMethodID (class_ref, "lerPeso", "(Lbr/com/itfast/tectoy/TectoyBalancaCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_lerPeso_Lbr_com_itfast_tectoy_TectoyBalancaCallback_, __args);
		}

		static Delegate cb_ligarLedStatus_Lbr_com_itfast_tectoy_CorLed_;
#pragma warning disable 0169
		static Delegate GetLigarLedStatus_Lbr_com_itfast_tectoy_CorLed_Handler ()
		{
			if (cb_ligarLedStatus_Lbr_com_itfast_tectoy_CorLed_ == null)
				cb_ligarLedStatus_Lbr_com_itfast_tectoy_CorLed_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_LigarLedStatus_Lbr_com_itfast_tectoy_CorLed_));
			return cb_ligarLedStatus_Lbr_com_itfast_tectoy_CorLed_;
		}

		static void n_LigarLedStatus_Lbr_com_itfast_tectoy_CorLed_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.CorLed> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LigarLedStatus (p0);
		}
#pragma warning restore 0169

		IntPtr id_ligarLedStatus_Lbr_com_itfast_tectoy_CorLed_;
		public unsafe void LigarLedStatus (global::BR.Com.Itfast.Tectoy.CorLed p0)
		{
			if (id_ligarLedStatus_Lbr_com_itfast_tectoy_CorLed_ == IntPtr.Zero)
				id_ligarLedStatus_Lbr_com_itfast_tectoy_CorLed_ = JNIEnv.GetMethodID (class_ref, "ligarLedStatus", "(Lbr/com/itfast/tectoy/CorLed;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ligarLedStatus_Lbr_com_itfast_tectoy_CorLed_, __args);
		}

		static Delegate cb_limparDisplay;
#pragma warning disable 0169
		static Delegate GetLimparDisplayHandler ()
		{
			if (cb_limparDisplay == null)
				cb_limparDisplay = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_LimparDisplay));
			return cb_limparDisplay;
		}

		static void n_LimparDisplay (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LimparDisplay ();
		}
#pragma warning restore 0169

		IntPtr id_limparDisplay;
		public unsafe void LimparDisplay ()
		{
			if (id_limparDisplay == IntPtr.Zero)
				id_limparDisplay = JNIEnv.GetMethodID (class_ref, "limparDisplay", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_limparDisplay);
		}

		static Delegate cb_loopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I;
#pragma warning disable 0169
		static Delegate GetLoopLigarStatus_Lbr_com_itfast_tectoy_CorLed_IHandler ()
		{
			if (cb_loopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I == null)
				cb_loopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_LoopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I));
			return cb_loopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I;
		}

		static void n_LoopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.CorLed> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoopLigarStatus (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_loopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I;
		public unsafe void LoopLigarStatus (global::BR.Com.Itfast.Tectoy.CorLed p0, int p1)
		{
			if (id_loopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I == IntPtr.Zero)
				id_loopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I = JNIEnv.GetMethodID (class_ref, "loopLigarStatus", "(Lbr/com/itfast/tectoy/CorLed;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loopLigarStatus_Lbr_com_itfast_tectoy_CorLed_I, __args);
		}

		static Delegate cb_macBalanca;
#pragma warning disable 0169
		static Delegate GetMacBalancaHandler ()
		{
			if (cb_macBalanca == null)
				cb_macBalanca = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_MacBalanca));
			return cb_macBalanca;
		}

		static IntPtr n_MacBalanca (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MacBalanca ());
		}
#pragma warning restore 0169

		IntPtr id_macBalanca;
		public unsafe string MacBalanca ()
		{
			if (id_macBalanca == IntPtr.Zero)
				id_macBalanca = JNIEnv.GetMethodID (class_ref, "macBalanca", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_macBalanca), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_modeloScanner;
#pragma warning disable 0169
		static Delegate GetModeloScannerHandler ()
		{
			if (cb_modeloScanner == null)
				cb_modeloScanner = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_ModeloScanner));
			return cb_modeloScanner;
		}

		static IntPtr n_ModeloScanner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ModeloScanner ());
		}
#pragma warning restore 0169

		IntPtr id_modeloScanner;
		public unsafe string ModeloScanner ()
		{
			if (id_modeloScanner == IntPtr.Zero)
				id_modeloScanner = JNIEnv.GetMethodID (class_ref, "modeloScanner", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_modeloScanner), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_newIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetNewIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_newIntent_Landroid_content_Intent_ == null)
				cb_newIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_NewIntent_Landroid_content_Intent_));
			return cb_newIntent_Landroid_content_Intent_;
		}

		static void n_NewIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NewIntent (p0);
		}
#pragma warning restore 0169

		IntPtr id_newIntent_Landroid_content_Intent_;
		public unsafe void NewIntent (global::Android.Content.Intent p0)
		{
			if (id_newIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_newIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "newIntent", "(Landroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_newIntent_Landroid_content_Intent_, __args);
		}

		static Delegate cb_onPause_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnPause_Landroid_app_Activity_Handler ()
		{
			if (cb_onPause_Landroid_app_Activity_ == null)
				cb_onPause_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnPause_Landroid_app_Activity_));
			return cb_onPause_Landroid_app_Activity_;
		}

		static void n_OnPause_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPause_Landroid_app_Activity_;
		public unsafe void OnPause (global::Android.App.Activity p0)
		{
			if (id_onPause_Landroid_app_Activity_ == IntPtr.Zero)
				id_onPause_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "onPause", "(Landroid/app/Activity;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause_Landroid_app_Activity_, __args);
		}

		static Delegate cb_onResume_Landroid_app_Activity_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetOnResume_Landroid_app_Activity_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_onResume_Landroid_app_Activity_Landroid_app_PendingIntent_ == null)
				cb_onResume_Landroid_app_Activity_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_OnResume_Landroid_app_Activity_Landroid_app_PendingIntent_));
			return cb_onResume_Landroid_app_Activity_Landroid_app_PendingIntent_;
		}

		static void n_OnResume_Landroid_app_Activity_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResume (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResume_Landroid_app_Activity_Landroid_app_PendingIntent_;
		public unsafe void OnResume (global::Android.App.Activity p0, global::Android.App.PendingIntent p1)
		{
			if (id_onResume_Landroid_app_Activity_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_onResume_Landroid_app_Activity_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "onResume", "(Landroid/app/Activity;Landroid/app/PendingIntent;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume_Landroid_app_Activity_Landroid_app_PendingIntent_, __args);
		}

		static Delegate cb_pararScanner;
#pragma warning disable 0169
		static Delegate GetPararScannerHandler ()
		{
			if (cb_pararScanner == null)
				cb_pararScanner = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PararScanner));
			return cb_pararScanner;
		}

		static void n_PararScanner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PararScanner ();
		}
#pragma warning restore 0169

		IntPtr id_pararScanner;
		public unsafe void PararScanner ()
		{
			if (id_pararScanner == IntPtr.Zero)
				id_pararScanner = JNIEnv.GetMethodID (class_ref, "pararScanner", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pararScanner);
		}

		static Delegate cb_posicionarEtiqueta;
#pragma warning disable 0169
		static Delegate GetPosicionarEtiquetaHandler ()
		{
			if (cb_posicionarEtiqueta == null)
				cb_posicionarEtiqueta = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_PosicionarEtiqueta));
			return cb_posicionarEtiqueta;
		}

		static void n_PosicionarEtiqueta (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PosicionarEtiqueta ();
		}
#pragma warning restore 0169

		IntPtr id_posicionarEtiqueta;
		public unsafe void PosicionarEtiqueta ()
		{
			if (id_posicionarEtiqueta == IntPtr.Zero)
				id_posicionarEtiqueta = JNIEnv.GetMethodID (class_ref, "posicionarEtiqueta", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_posicionarEtiqueta);
		}

		static Delegate cb_qrCodeDisplay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQrCodeDisplay_Ljava_lang_String_Handler ()
		{
			if (cb_qrCodeDisplay_Ljava_lang_String_ == null)
				cb_qrCodeDisplay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_QrCodeDisplay_Ljava_lang_String_));
			return cb_qrCodeDisplay_Ljava_lang_String_;
		}

		static void n_QrCodeDisplay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QrCodeDisplay (p0);
		}
#pragma warning restore 0169

		IntPtr id_qrCodeDisplay_Ljava_lang_String_;
		public unsafe void QrCodeDisplay (string p0)
		{
			if (id_qrCodeDisplay_Ljava_lang_String_ == IntPtr.Zero)
				id_qrCodeDisplay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "qrCodeDisplay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString ((string)p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_qrCodeDisplay_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_readNAN_IarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetReadNAN_IarrayBarrayBarrayBHandler ()
		{
			if (cb_readNAN_IarrayBarrayBarrayB == null)
				cb_readNAN_IarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPILLL_I (n_ReadNAN_IarrayBarrayBarrayB));
			return cb_readNAN_IarrayBarrayBarrayB;
		}

		static int n_ReadNAN_IarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadNAN (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readNAN_IarrayBarrayBarrayB;
		public unsafe int ReadNAN (int p0, byte[] p1, byte[] p2, byte[] p3)
		{
			if (id_readNAN_IarrayBarrayBarrayB == IntPtr.Zero)
				id_readNAN_IarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "readNAN", "(I[B[B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readNAN_IarrayBarrayBarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate cb_readSBInfo_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetReadSBInfo_arrayBarrayBHandler ()
		{
			if (cb_readSBInfo_arrayBarrayB == null)
				cb_readSBInfo_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_ReadSBInfo_arrayBarrayB));
			return cb_readSBInfo_arrayBarrayB;
		}

		static int n_ReadSBInfo_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadSBInfo (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readSBInfo_arrayBarrayB;
		public unsafe int ReadSBInfo (byte[] p0, byte[] p1)
		{
			if (id_readSBInfo_arrayBarrayB == IntPtr.Zero)
				id_readSBInfo_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "readSBInfo", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readSBInfo_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfAuthEntication_IarrayB;
#pragma warning disable 0169
		static Delegate GetRfAuthEntication_IarrayBHandler ()
		{
			if (cb_rfAuthEntication_IarrayB == null)
				cb_rfAuthEntication_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_RfAuthEntication_IarrayB));
			return cb_rfAuthEntication_IarrayB;
		}

		static int n_RfAuthEntication_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfAuthEntication (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfAuthEntication_IarrayB;
		public unsafe int RfAuthEntication (int p0, byte[] p1)
		{
			if (id_rfAuthEntication_IarrayB == IntPtr.Zero)
				id_rfAuthEntication_IarrayB = JNIEnv.GetMethodID (class_ref, "rfAuthEntication", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfAuthEntication_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfCard_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetRfCard_arrayBarrayBHandler ()
		{
			if (cb_rfCard_arrayBarrayB == null)
				cb_rfCard_arrayBarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_I (n_RfCard_arrayBarrayB));
			return cb_rfCard_arrayBarrayB;
		}

		static int n_RfCard_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfCard (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfCard_arrayBarrayB;
		public unsafe int RfCard (byte[] p0, byte[] p1)
		{
			if (id_rfCard_arrayBarrayB == IntPtr.Zero)
				id_rfCard_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "rfCard", "([B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfCard_arrayBarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfDecrement_II;
#pragma warning disable 0169
		static Delegate GetRfDecrement_IIHandler ()
		{
			if (cb_rfDecrement_II == null)
				cb_rfDecrement_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_RfDecrement_II));
			return cb_rfDecrement_II;
		}

		static int n_RfDecrement_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfDecrement (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_rfDecrement_II;
		public unsafe int RfDecrement (int p0, int p1)
		{
			if (id_rfDecrement_II == IntPtr.Zero)
				id_rfDecrement_II = JNIEnv.GetMethodID (class_ref, "rfDecrement", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfDecrement_II, __args);
		}

		static Delegate cb_rfIncrement_II;
#pragma warning disable 0169
		static Delegate GetRfIncrement_IIHandler ()
		{
			if (cb_rfIncrement_II == null)
				cb_rfIncrement_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_RfIncrement_II));
			return cb_rfIncrement_II;
		}

		static int n_RfIncrement_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfIncrement (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_rfIncrement_II;
		public unsafe int RfIncrement (int p0, int p1)
		{
			if (id_rfIncrement_II == IntPtr.Zero)
				id_rfIncrement_II = JNIEnv.GetMethodID (class_ref, "rfIncrement", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfIncrement_II, __args);
		}

		static Delegate cb_rfInitVal_II;
#pragma warning disable 0169
		static Delegate GetRfInitVal_IIHandler ()
		{
			if (cb_rfInitVal_II == null)
				cb_rfInitVal_II = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPII_I (n_RfInitVal_II));
			return cb_rfInitVal_II;
		}

		static int n_RfInitVal_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RfInitVal (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_rfInitVal_II;
		public unsafe int RfInitVal (int p0, int p1)
		{
			if (id_rfInitVal_II == IntPtr.Zero)
				id_rfInitVal_II = JNIEnv.GetMethodID (class_ref, "rfInitVal", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfInitVal_II, __args);
		}

		static Delegate cb_rfRead_IarrayB;
#pragma warning disable 0169
		static Delegate GetRfRead_IarrayBHandler ()
		{
			if (cb_rfRead_IarrayB == null)
				cb_rfRead_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_RfRead_IarrayB));
			return cb_rfRead_IarrayB;
		}

		static int n_RfRead_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfRead (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfRead_IarrayB;
		public unsafe int RfRead (int p0, byte[] p1)
		{
			if (id_rfRead_IarrayB == IntPtr.Zero)
				id_rfRead_IarrayB = JNIEnv.GetMethodID (class_ref, "rfRead", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfRead_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfReadVal_IarrayI;
#pragma warning disable 0169
		static Delegate GetRfReadVal_IarrayIHandler ()
		{
			if (cb_rfReadVal_IarrayI == null)
				cb_rfReadVal_IarrayI = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_RfReadVal_IarrayI));
			return cb_rfReadVal_IarrayI;
		}

		static int n_RfReadVal_IarrayI (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.RfReadVal (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfReadVal_IarrayI;
		public unsafe int RfReadVal (int p0, int[] p1)
		{
			if (id_rfReadVal_IarrayI == IntPtr.Zero)
				id_rfReadVal_IarrayI = JNIEnv.GetMethodID (class_ref, "rfReadVal", "(I[I)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfReadVal_IarrayI, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfWrite_IarrayB;
#pragma warning disable 0169
		static Delegate GetRfWrite_IarrayBHandler ()
		{
			if (cb_rfWrite_IarrayB == null)
				cb_rfWrite_IarrayB = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPIL_I (n_RfWrite_IarrayB));
			return cb_rfWrite_IarrayB;
		}

		static int n_RfWrite_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.RfWrite (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rfWrite_IarrayB;
		public unsafe int RfWrite (int p0, byte[] p1)
		{
			if (id_rfWrite_IarrayB == IntPtr.Zero)
				id_rfWrite_IarrayB = JNIEnv.GetMethodID (class_ref, "rfWrite", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfWrite_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_rfhalt;
#pragma warning disable 0169
		static Delegate GetRfhaltHandler ()
		{
			if (cb_rfhalt == null)
				cb_rfhalt = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_I (n_Rfhalt));
			return cb_rfhalt;
		}

		static int n_Rfhalt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rfhalt ();
		}
#pragma warning restore 0169

		IntPtr id_rfhalt;
		public unsafe int Rfhalt ()
		{
			if (id_rfhalt == IntPtr.Zero)
				id_rfhalt = JNIEnv.GetMethodID (class_ref, "rfhalt", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rfhalt);
		}

		static Delegate cb_statusImpressora;
#pragma warning disable 0169
		static Delegate GetStatusImpressoraHandler ()
		{
			if (cb_statusImpressora == null)
				cb_statusImpressora = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_StatusImpressora));
			return cb_statusImpressora;
		}

		static IntPtr n_StatusImpressora (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.Service.ITecToyServices> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StatusImpressora ());
		}
#pragma warning restore 0169

		IntPtr id_statusImpressora;
		public unsafe global::BR.Com.Itfast.Tectoy.StatusImpressora StatusImpressora ()
		{
			if (id_statusImpressora == IntPtr.Zero)
				id_statusImpressora = JNIEnv.GetMethodID (class_ref, "statusImpressora", "()Lbr/com/itfast/tectoy/StatusImpressora;");
			return global::Java.Lang.Object.GetObject<global::BR.Com.Itfast.Tectoy.StatusImpressora> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_statusImpressora), JniHandleOwnership.TransferLocalRef);
		}

	}
}
