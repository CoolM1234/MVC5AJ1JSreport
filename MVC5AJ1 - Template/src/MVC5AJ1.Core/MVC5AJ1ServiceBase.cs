using Abp;

namespace MVC5AJ1
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="MVC5AJ1DomainServiceBase"/>.
    /// For application services inherit MVC5AJ1AppServiceBase.
    /// </summary>
    public abstract class MVC5AJ1ServiceBase : AbpServiceBase
    {
        protected MVC5AJ1ServiceBase()
        {
            LocalizationSourceName = MVC5AJ1Consts.LocalizationSourceName;
        }
    }
}