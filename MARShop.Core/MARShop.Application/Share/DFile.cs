using System.Collections.Generic;
using System.IO;

namespace MARShop.Application.Share
{
    public class DFile
    {
        public static string GetType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }
        private static Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformatsofficedocument.spreadsheetml.sheet"},  
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        public static void WriteData(string fileName, string fileContent, string directory)
        {
            var imageIdentityDirectory = directory;
            var imageIdentityUrl = imageIdentityDirectory + fileName;
            var imageIdentityBase64 = DConvertor.Base64WithHeaderToBytes(fileContent);
            Directory.CreateDirectory(imageIdentityDirectory);
            System.IO.File.WriteAllBytes(imageIdentityUrl, imageIdentityBase64);
        }
    }
}
