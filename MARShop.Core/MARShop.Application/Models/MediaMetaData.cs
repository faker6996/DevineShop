using MARShop.Application.Share;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace MARShop.Application.Models
{
    public class MediaProductInfo
    {
        public string MediaLink { get; set; }
        public string MediaContent { get; set; }
        public string MediaName { get; set; }
        public string ProductLink { get; set; }

        public MediaProductInfo()
        {

        }
        public MediaProductInfo(string mediaLink)
        {
            MediaLink= mediaLink;
            MediaContent = DConvertor.FileUrlToBase64(mediaLink);
            MediaName = Path.GetFileName(mediaLink);
        }  public MediaProductInfo(string mediaLink,string productLink)
        {
            MediaLink= mediaLink;
            MediaContent = DConvertor.FileUrlToBase64(mediaLink);
            MediaName = Path.GetFileName(mediaLink);
            ProductLink = productLink;
        }
    }

    public class MediaMetaData
    {
        public List<MediaProductInfo> MediaProductInfos { get; set; }
        public string MediaName { get; set; }
        public MediaMetaData()
        {
            MediaProductInfos = new List<MediaProductInfo>();
        }
    }
}
