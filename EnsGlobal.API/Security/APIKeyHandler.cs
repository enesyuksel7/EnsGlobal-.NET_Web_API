using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using EnsGlobal.DAL;

namespace EnsGlobal.API.Security
{
    public class APIKeyHandler:DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var sorguString = request.RequestUri.ParseQueryString();
            var apiKey = sorguString["apiKey"];
            /*var user = request.Headers.GetValues("apiKey").FirstOrDefault();*/ //Telerik ve postman dan değer girip sorgulama için
            string key1 = "8;N:nP>J?Wk`~`Rb";
            string key2 = "2{uh=A~4^;qUyt.%";
            string key3 = "ePzsLed_9h)x%Zg{";
            if (key1 == apiKey || key2 == apiKey || key3 == apiKey)
            {
                var yetkili = new ClaimsPrincipal(new GenericIdentity("Admin", "APIKey"));
                HttpContext.Current.User = yetkili;
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}