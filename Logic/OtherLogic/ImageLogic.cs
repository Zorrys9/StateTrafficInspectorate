using System.IO;
using System.Windows.Media.Imaging;

namespace Logic.OtherLogic
{
    public class ImageLogic
    {

        public static BitmapImage ImageFromByte(byte[] img)
        {
            if (img == null)
            {
                return null;
            }
            else
            {
                var memory = new MemoryStream(img);
                var image = new BitmapImage();
                memory.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = memory;
                image.EndInit();
                image.Freeze();
                return image;
            }

        }
        public static byte[] ByteFromImage(string imageURL)
        {
            return File.ReadAllBytes(imageURL);
        }

    }
}
