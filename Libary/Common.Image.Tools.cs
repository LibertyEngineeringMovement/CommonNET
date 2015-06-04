using System;
using System.IO;
using System.Drawing;

namespace Common.Image
{
    public static class Tools
    {
        private static string CreateBase64Image(byte[] fileBytes)
        {
            Image streamImage;
 
            using (MemoryStream ms = new MemoryStream(fileBytes))
            {
                /* Create a new image, saved as a scaled version of the original */
                streamImage = ScaleImage(Image.FromStream(ms));
            }
 
            using (MemoryStream ms = new MemoryStream())
            {
                /* Convert this image back to a base64 string */
                streamImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }
}
