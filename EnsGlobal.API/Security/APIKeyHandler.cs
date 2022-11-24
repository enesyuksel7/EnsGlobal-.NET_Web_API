using EnsGlobal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace EnsGlobal.API.Security
{
    public class APIKeyHandler:DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var queryString = request.RequestUri.ParseQueryString();
            var apiKey = queryString["apiKey"];
            string apiKey1 = "2{uh=A~4^;qUyt.%", apiKey2 = "ePzsLed_9h)x%Zg{";
            if(apiKey == apiKey1 || apiKey == apiKey2)
            {
                var principal = new ClaimsPrincipal(new GenericIdentity("APIKey"));
                HttpContext.Current.User=principal;
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}