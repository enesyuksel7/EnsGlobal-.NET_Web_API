using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EnsGlobal.FORM
{
    public static class RestHelper
    {
        private static readonly string baseURL = "http://www.mekadeneme.somee.com/api/";

        public static async Task<string> GetALL()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "Satislar?apiKey=ePzsLed_9h)x%Zg{"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        if(data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "Satislar/" + id+"?apiKey=ePzsLed_9h)x%Zg{"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();

                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        //public static async Task<string> Post(int urunId, string yetkili, DateTime tarih, int ucret, int vergi)
        //{

        //    var inputData = new Dictionary<string, object>
        //    {
        //        { "UrunID", urunId },
        //        { "Yetkili", yetkili },
        //        { "Tarih", tarih },
        //        { "Ucret", ucret },
        //        { "Vergi", vergi }
        //    };

        //    var input = new FormUrlEncodedContent(inputData);
        //    using (HttpClient client = new HttpClient())
        //    {
        //        using (HttpResponseMessage res = await client.PostAsync("http://www.mekadeneme.somee.com/api/" + "Satislar/" + urunId + "?apiKey=ePzsLed_9h)x%Zg{", input))
        //        {
        //            using (HttpContent content = res.Content)
        //            {
        //                string data = await content.ReadAsStringAsync();
        //                if (data != null)
        //                {
        //                    return data;
        //                }
        //            }
        //        }
        //    }
        //    return string.Empty;
        //}

    }
}
