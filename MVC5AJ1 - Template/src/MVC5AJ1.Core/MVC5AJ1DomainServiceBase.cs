using Abp.Domain.Services;

namespace MVC5AJ1
{
    public abstract class MVC5AJ1DomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected MVC5AJ1DomainServiceBase()
        {
            LocalizationSourceName = MVC5AJ1Consts.LocalizationSourceName;
        }
    }
}
