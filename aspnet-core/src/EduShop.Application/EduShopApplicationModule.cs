using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EduShop.Authorization;

namespace EduShop
{
    [DependsOn(
        typeof(EduShopCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EduShopApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EduShopAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EduShopApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
