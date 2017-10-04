using System.Reflection;
using Abp.AutoMapper;
using Abp.Localization;
using Abp.Modules;
using MVC5AJ1.Authorization;

namespace MVC5AJ1
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(typeof(MVC5AJ1CoreModule))]
    public class MVC5AJ1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper mappings
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                CustomDtoMapper.CreateMappings(mapper);
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
