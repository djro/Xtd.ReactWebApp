using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Xtd.ReactWebApp.Localization
{
    public static class ReactWebAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ReactWebAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ReactWebAppLocalizationConfigurer).GetAssembly(),
                        "Xtd.ReactWebApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
