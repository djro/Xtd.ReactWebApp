using System.Threading.Tasks;
using Xtd.ReactWebApp.Configuration.Dto;

namespace Xtd.ReactWebApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
