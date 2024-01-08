using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using BR.Com.Itfast.Tectoy;
using System.Reflection.Emit;
using Android.Widget;
using Java.Lang;
using Android.Content;
using static Android.Bluetooth.BluetoothClass;
using Android.Nfc;

namespace XamarinTecToy
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    [IntentFilter(new[] { NfcAdapter.ActionNdefDiscovered, NfcAdapter.ActionTagDiscovered, Intent.CategoryDefault })]
    public class MainActivity : AppCompatActivity, ITecToyNfcCallback
    {
        private TecToy tectoy = null;
        private PendingIntent pendingIntent = null;
        private EditText txtImprimir;
        private EditText txtEscreverNFC;
        private TextView txtValorNFC;

        public void RetornarValor(string p0)
        {
            txtValorNFC.Text = p0;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Button btnImprimir = FindViewById<Button>(Resource.Id.btnImprimir);
            btnImprimir.Click += OnBtnImprimirClicked;

            Button btnEscreverNFC = FindViewById<Button>(Resource.Id.btnEscreverNFC);
            btnEscreverNFC.Click += OnBtnEscreverNfcClicked;

            Button btnImpFormatado = FindViewById<Button>(Resource.Id.btnImpFormatado);
            btnImpFormatado.Click += OnBtnImpFormatadoClicked;

            txtImprimir = FindViewById<EditText>(Resource.Id.txtImprimir);
            txtValorNFC = FindViewById<TextView>(Resource.Id.txtValorNFC);
            txtEscreverNFC = FindViewById<EditText>(Resource.Id.txtEscreverNFC);

            tectoy = new TecToy(Dispositivo.V2Pro, this);

            pendingIntent = PendingIntent.GetActivity(this, 0, new Intent(this, Java.Lang.Class.ForName(this.Class.CanonicalName)).AddFlags(ActivityFlags.SingleTop), 0);
            tectoy.IniciarNFC(Intent, this);
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
            tectoy.OnNewIntentNFC(intent);
        }

        protected override void OnPause()
        {
            base.OnPause();
            tectoy.OnPauseNFC(this);
        }

        protected override void OnResume()
        {
            base.OnResume();
            if(pendingIntent != null)
            {
                tectoy.OnResumeNFC(this, pendingIntent);
            }

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        private void OnBtnImprimirClicked(object sender, EventArgs args)
        {
            try
            {
                tectoy.Imprimir(txtImprimir.Text );
                Toast.MakeText(this, "Impressão ok!", ToastLength.Long).Show();
            }
            catch(TecToyException ex)
            {
                Toast.MakeText(this, "Erro na impressão! " + ex.Message, ToastLength.Long).Show();
            }

        }

        private void OnBtnEscreverNfcClicked(object sender, EventArgs args)
        {
            try
            {
                tectoy.EscreverNFC(txtEscreverNFC.Text);
                Toast.MakeText(this, "Escrita NFC ok!", ToastLength.Long).Show();
            }
            catch (TecToyException ex)
            {
                Toast.MakeText(this, "Erro na escrita NFC! " + ex.Message, ToastLength.Long).Show();
            }

        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void OnBtnImpFormatadoClicked(object sender, EventArgs args)
        {
            string textoFormatado = "";
            //Comandos ESC/POS de formatação para uso na impressão de texto
            string centro = "" + ((char)0x1B) + ((char)0x61) + ((char)0x31);
            string deslCentro = "" + ((char)0x1B) + ((char)0x61) + ((char)0x30);
            string direita = "" + ((char)0x1B) + ((char)0x61) + ((char)0x32);
            string deslDireita = "" + ((char)0x1B) + ((char)0x61) + ((char)0x30);
            ///Fonte dupla altura 
            string dupAlt = "" + ((char)0x1B) + ((char)0x21) + ((char)0x16);
            ///FOnte dupla largura
            string dupLargura = "" + ((char)0x1B) + ((char)0x21) + ((char)0x20);
            ///desliga dupla altura ou largura
            string deslDupla = "" + ((char)0x1B) + ((char)0x21) + ((char)0x00);
            // fonte extra grande
            string extraG = "" + ((char)0x1D) + ((char)0x21) + ((char)0x64);
            string deslExtra = "" + ((char)0x1D) + ((char)0x21) + ((char)0x00);
            string negrito = "" + ((char)0x1B) + ((char)0x45) + ((char)0x31);
            string deslNegrito = "" + ((char)0x1B) + ((char)0x45) + ((char)0x30);
            string invetImp = "" + ((char)0x1D) + ((char)0x42) + ((char)0x31);
            string desligInvert = "" + ((char)0x1D) + ((char)0x42) + ((char)0x30);

            textoFormatado = invetImp + centro + extraG + negrito + "TEC\nTOY" + deslNegrito + deslExtra + "\n" + desligInvert;
            textoFormatado += centro + dupLargura + "Teste formatado" + " / " + "Dupla largura" + deslDupla + "\n\n";
            textoFormatado += deslCentro + dupAlt + "Fonte dupla Altura" + " - " + "TecToy Automação" + deslDupla + "\n\n";
            textoFormatado += centro + dupAlt + negrito + "Centro Negrito DuplAlt" + deslNegrito + deslDupla + "\n\n";
            textoFormatado += deslCentro + "NORMAL\n IT FAST" + ((char)0xAE) + "\n Teste Tectoy" + ((char)0x99) + "\n\n\n\n";
            try
            {
                tectoy.Imprimir(textoFormatado);
                Toast.MakeText(this, "Impressão ok!", ToastLength.Long).Show();
            }
            catch (TecToyException ex)
            {
                Toast.MakeText(this, "Erro na impressão! " + ex.Message, ToastLength.Long).Show();
            }

        }

        public void RetornarId(string p0)
        {
            throw new NotImplementedException();
        }
    }
}
