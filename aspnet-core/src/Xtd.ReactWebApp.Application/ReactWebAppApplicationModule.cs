using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Xtd.ReactWebApp.Authorization;

namespace Xtd.ReactWebApp
{
    [DependsOn(
        typeof(ReactWebAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ReactWebAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ReactWebAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ReactWebAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
