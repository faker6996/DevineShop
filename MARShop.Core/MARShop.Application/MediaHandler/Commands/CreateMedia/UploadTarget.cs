using MARShop.Application.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MARShop.Application.MediaHandler.Commands.CreateMedia
{
    
    public class AddTargetResponse
    {
        public string result_code { get; set; }
        public string transaction_id { get; set; }
        public string target_id { get; set; }
    }
    //public static class GetTarget
    //{
    //    private static string endpoint = "https://vws.vuforia.com/targets";

    //    public static string GetInfoTarget(VWSGet vwsGet)
    //    {
    //        var request = (HttpWebRequest)WebRequest.Create(string.Format("{0}/{1}", endpoint, vwsGet.IdTarget));

    //        request.Method = "GET";
    //        request.Date = DateTime.Now.ToUniversalTime();
    //        request.Headers.Set(HttpRequestHeader.Authorization, string.Format("VWS {0}:{1}", vwsGet.AccessKey, GetSignatureNoPayload(vwsGet.SecretKey, request.Method, string.Format("/targets/{0}", vwsGet.IdTarget))));

    //        try
    //        {
    //            using (var response = request.GetResponse())
    //            {
    //                var streamData = response.GetResponseStream();
    //                StreamReader reader = new StreamReader(streamData);
    //                object result = reader.ReadToEnd();
    //                streamData.Close();
    //                response.Close();
    //                return result.ToString();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            return ex.Message;
    //        }
    //    }

    //    private static string GetSignatureNoPayload(string secretKey, string method, string route)
    //    {
    //        string date = string.Format("{0:r}", DateTime.Now.ToUniversalTime());

    //        MD5 md5 = MD5.Create();
    //        var contentMD5bytes = md5.ComputeHash(Encoding.ASCII.GetBytes(string.Empty));

    //        StringBuilder sb = new StringBuilder();
    //        for (int i = 0; i < contentMD5bytes.Length; i++)
    //        {
    //            sb.Append(contentMD5bytes[i].ToString("x2"));
    //        }

    //        string contentMD5 = sb.ToString();
    //        string stringToSign = string.Format("{0}\n{1}\n{2}\n{3}\n{4}", method, contentMD5, string.Empty, date, route);

    //        HMACSHA1 sha1 = new HMACSHA1(Encoding.ASCII.GetBytes(secretKey));
    //        byte[] sha1Bytes = Encoding.ASCII.GetBytes(stringToSign);
    //        MemoryStream stream = new MemoryStream(sha1Bytes);
    //        byte[] sha1Hash = sha1.ComputeHash(stream);
    //        string signature = Convert.ToBase64String(sha1Hash);

    //        return signature;
    //    }
    //}
    
    
}
