using Abp.AutoMapper;
using Xtd.ReactWebApp.Authentication.External;

namespace Xtd.ReactWebApp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
