using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Xtd.ReactWebApp.Authorization.Users;
using Xtd.ReactWebApp.Editions;

namespace Xtd.ReactWebApp.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
