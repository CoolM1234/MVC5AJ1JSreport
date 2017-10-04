using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using MVC5AJ1.EntityFramework;

namespace MVC5AJ1.Migrator
{
    [DependsOn(typeof(MVC5AJ1DataModule))]
    public class MVC5AJ1MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MVC5AJ1DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}