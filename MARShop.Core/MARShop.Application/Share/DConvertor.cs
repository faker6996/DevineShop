using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace MARShop.Application.Share
{
    public class DConvertor
    {
        public static string FileToBase64(IFormFile file)
        {
            if (file.Length > 0)
            {
                var memoryStream = new MemoryStream();
                file.CopyTo(memoryStream);
                var fileBytes = memoryStream.ToArray();
                return Convert.ToBase64String(fileBytes);
            }
            return null;
        }
        public static string FileUrlToBase64(string path)
        {
            Byte[] bytes = File.ReadAllBytes(path);
            return Convert.ToBase64String(bytes);
        }
        public static byte[] Base64WithHeaderToBytes(string content)
        {
            var contentAfterRemoveHeader = content.Substring(content.LastIndexOf(',') + 1);
            return Convert.FromBase64String(contentAfterRemoveHeader);
        }
        public static string GetJsonValueByKey(string json, string key)
        {
            var data = (JObject)JsonConvert.DeserializeObject(json);
            return data[key].Value<string>();
        }
        public static string Bas64Of32bitsTo24bits(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            var bmp = new Bitmap(image.Width, image.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));

            string result = "";
            using (var ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                result = Convert.ToBase64String(ms.GetBuffer()); //Get Base64
            }
            return result;
        }
        public static string StringToBase64(string input)
        {
            var bytesData = System.Text.Encoding.UTF8.GetBytes(input);
           return System.Convert.ToBase64String(bytesData);
        }
    }
}
