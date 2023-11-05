using System;
using System.Threading.Tasks;

namespace DependencyService
{
    public interface IQRCodeScanner
    {
        // Método para iniciar la lectura de un código QR
        Task<string> ScanQRCodeAsync();
    }
}
