using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Xtd.ReactWebApp.Configuration.Dto;

namespace Xtd.ReactWebApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ReactWebAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
