using Microsoft.AspNetCore.Antiforgery;
using Xtd.ReactWebApp.Controllers;

namespace Xtd.ReactWebApp.Web.Host.Controllers
{
    public class AntiForgeryController : ReactWebAppControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
