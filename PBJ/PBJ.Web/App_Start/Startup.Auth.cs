using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IdentityModel.Claims;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Owin;
using PBJ.Web.Models;

namespace PBJ.Web
{
    public partial class Startup
    {
        private static readonly string _clientId = ConfigurationManager.AppSettings["ida:ClientId"];
        private static readonly string _appKey = ConfigurationManager.AppSettings["ida:ClientSecret"];
        private static readonly string _aadInstance = ConfigurationManager.AppSettings["ida:AADInstance"];
        private static readonly string _tenantId = ConfigurationManager.AppSettings["ida:TenantId"];
        private static readonly string _postLogoutRedirectUri = ConfigurationManager.AppSettings["ida:PostLogoutRedirectUri"];

        public static readonly string Authority = _aadInstance + _tenantId;

        // This is the resource ID of the AAD Graph API.  We'll need this to request a token to call the Graph API.
       // string graphResourceId = "https://graph.windows.net";

        public void ConfigureAuth(IAppBuilder app)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions());

            app.UseOpenIdConnectAuthentication(
                new OpenIdConnectAuthenticationOptions
                {
                    ClientId = _clientId,
                    Authority = Authority,
                    PostLogoutRedirectUri = _postLogoutRedirectUri,

                    Notifications = new OpenIdConnectAuthenticationNotifications()
                    {
                        // If there is a code in the OpenID Connect response, redeem it for an access token and refresh token, and store those away.
                       AuthorizationCodeReceived = (context) => 
                       {
                           var code = context.Code;
                           ClientCredential credential = new ClientCredential(_clientId, _appKey);
                           string signedInUserId = context.AuthenticationTicket.Identity.FindFirst(ClaimTypes.NameIdentifier).Value;
                           // TODO save token
                           //AuthenticationContext authContext = new AuthenticationContext(Authority, new ADALTokenCache(signedInUserID));
                           //AuthenticationResult result = authContext.AcquireTokenByAuthorizationCode(
                           //code, new Uri(HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path)), credential, graphResourceId);

                           return Task.FromResult(0);
                       }
                    }
                });
        }
    }
}
