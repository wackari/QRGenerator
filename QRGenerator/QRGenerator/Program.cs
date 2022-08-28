using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

string UrlQR = "https://linktr.ee/wakari";
string imagePath = "img.png";


    QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
    QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(UrlQR, QRCodeGenerator.ECCLevel.Q);
    QRCode qRCode = new QRCode(qRCodeData);
    Bitmap qrCodeImage = qRCode.GetGraphic(10, Color.DarkCyan, Color.White, (Bitmap)Bitmap.FromFile(imagePath),25,20);
    qrCodeImage.Save(@"QRImage.bmp");
