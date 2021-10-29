using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Volga_IT_Belkov.Services
{
    static class ApiService
    {
        public static bool ValidateConnection()
        {
            try
            {
                Get("https://volgait.simbirsoft.dev/api/v1/common/banner");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string Get(string url, string token = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            if (!string.IsNullOrWhiteSpace(token))
                request.Headers.Add($"Authorization: Bearer {token}");
            WebResponse response = request.GetResponse();
            string result = "";
            using (StreamReader sr = new(response.GetResponseStream(), Encoding.UTF8))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
        /// <summary>
        /// Отправляет POST запрос на сервер
        /// </summary>
        /// <param name="url">Путь к методу API</param>
        /// <param name="content">Сериализованная JSON строка, добавляемая в тело запроса</param>
        /// <param name="token">Токен пользователя, добавляемый в заголовок запроса</param>
        /// <returns></returns>
        public static string Post(string url, string content, string token = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            if (!string.IsNullOrWhiteSpace(token))
                request.Headers.Add($"Authorization: Bearer {token}");
            request.ContentType = "text/json";
            byte[] contentBytes = Encoding.UTF8.GetBytes(content);
            request.ContentLength = contentBytes.Length;
            using (Stream s = request.GetRequestStream())
            {
                s.Write(contentBytes, 0, contentBytes.Length);
            }
            string result = "";
            WebResponse response = request.GetResponse();
            using (StreamReader sr = new(response.GetResponseStream(), Encoding.UTF8))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }

        public static string Put(string url, string content, string token = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "PUT";
            if (!string.IsNullOrWhiteSpace(token))
                request.Headers.Add($"Authorization: Bearer {token}");
            request.ContentType = "text/json";
            byte[] contentBytes = Encoding.UTF8.GetBytes(content);
            request.ContentLength = contentBytes.Length;
            using (Stream s = request.GetRequestStream())
            {
                s.Write(contentBytes, 0, contentBytes.Length);
            }
            string result = "";
            WebResponse response = request.GetResponse();
            using (StreamReader sr = new(response.GetResponseStream(), Encoding.UTF8))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}
