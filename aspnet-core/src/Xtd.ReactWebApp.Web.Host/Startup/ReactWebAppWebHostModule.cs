using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Xtd.ReactWebApp.Configuration;

namespace Xtd.ReactWebApp.Web.Host.Startup
{
    [DependsOn(
       typeof(ReactWebAppWebCoreModule))]
    public class ReactWebAppWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReactWebAppWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReactWebAppWebHostModule).GetAssembly());
        }
    }
}
