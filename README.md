# Dependencia de Servicios con Xamarin.Forms
Este proyecto de ejemplo muestra cómo utilizar DependencyService en Xamarin.Forms para acceder a características específicas de la plataforma en dispositivos Android. 
Se enfoca en tres funcionalidades clave: Text-to-Speech, obtención de información de la batería y escaneo de códigos QR.

## Contenido del Proyecto

- **TextToSpeechDemo:** Una página de contenido que permite al usuario hacer clic en un botón para escuchar un mensaje de bienvenida utilizando Text-to-Speech.
- **BatteryDemo:** Otra página de contenido que proporciona información sobre la batería del dispositivo, incluyendo el nivel de carga, el estado y la fuente de alimentación.
- **QRReaderPage:** Una página de contenido que permite al usuario escanear códigos QR utilizando la biblioteca ZXing.Net.Mobile.

## Interfaces

- **ITextToSpeech:** Define un contrato para la funcionalidad de Text-to-Speech.
- **IBattery:** Establece un contrato para obtener información sobre la batería del dispositivo.
- **IQRCodeScanner:** Define un contrato para el escaneo de códigos QR.

## Implementaciones en Android

- **TextToSpeechImplementation:** Implementa la interfaz `ITextToSpeech` para habilitar la lectura de texto a voz en dispositivos Android.
- **BatteryImplementation:** Implementa la interfaz `IBattery` para acceder a la información de la batería en dispositivos Android.
- **QRCodeScannerImplementation:** Implementa la interfaz `IQRCodeScanner` utilizando la biblioteca ZXing.Net.Mobile para realizar el escaneo de códigos QR en dispositivos Android.

## Cómo Utilizar

1. Clona o descarga este repositorio a tu entorno de desarrollo.
2. Abre el proyecto en Visual Studio o Xamarin Studio.
3. Ejecuta la aplicación en un dispositivo Android o un emulador.
4. Explora las páginas de contenido para experimentar con las funcionalidades de Text-to-Speech, información de la batería y escaneo de códigos QR.


