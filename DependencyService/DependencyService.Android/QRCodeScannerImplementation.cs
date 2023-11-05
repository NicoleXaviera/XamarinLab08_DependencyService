using System.Threading.Tasks;
using Android.App;
using DependencyService.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(QRCodeScannerImplementation))]
namespace DependencyService.Droid
{
    public class QRCodeScannerImplementation : IQRCodeScanner
    {
        public async Task<string> ScanQRCodeAsync()
        {
            var scannerPage = new ZXing.Net.Mobile.Forms.ZXingScannerPage();

            scannerPage.Title = "QR Code Scanner";

            string scannedValue = await Application.Current.MainPage.Navigation.PushAsync(scannerPage);

            return scannedValue;
        }
    }
}
