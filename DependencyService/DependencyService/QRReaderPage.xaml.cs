using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace DependencyService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRReaderPage : ContentPage
    {
        public QRReaderPage()
        {
            InitializeComponent();
        }

        // Método que se ejecuta cuando se hace clic en el botón
        private void Button_Clicked(object sender, EventArgs e)
        {
            // Llamar al método Scanner para iniciar la lectura del código QR
            Scanner();
        }

        // Método asincrónico para iniciar la lectura del código QR
        private async void Scanner()
        {
            // Crear una nueva página de escaneo ZXing
            var scannerPage = new ZXingScannerPage();

            // Establecer el título de la página de escaneo
            scannerPage.Title = "Lector de QR";

            // Asignar un controlador de eventos cuando se obtiene un resultado de escaneo
            scannerPage.OnScanResult += (result) =>
            {
                // Detener la captura de cámara
                scannerPage.IsScanning = false;

                // Realizar una operación en el subproceso principal
                Device.BeginInvokeOnMainThread(() =>
                {
                    // Regresar a la página anteriorS
                    Navigation.PopAsync();

                    // Mostrar un cuadro de diálogo con el valor del código QR escaneado
                    DisplayAlert("Valor Obtenido", result.Text, "OK");
                });
            };

            // Abrir la página de escaneo ZXing
            await Navigation.PushAsync(scannerPage);
        }
    }
}
