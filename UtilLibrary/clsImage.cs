using MyClassLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
namespace UtilLibrary
{
    public class clsImage
    {
        public static event Action<Image> OnImageLoaded;

        public static async Task LoadImageFromUrlAsync(string url)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    byte[] imageBytes = await httpClient.GetByteArrayAsync(url);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {

                        OnImageLoaded?.Invoke(Image.FromStream(ms));
                    }
                }
            }
            catch (Exception ex)
            {
                clsErrorHandling.HandleError(ex);
            }

        }
    }
}
