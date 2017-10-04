using Abp.WebApi.Controllers;

namespace MVC5AJ1.WebApi
{
    public abstract class MVC5AJ1ApiControllerBase : AbpApiController
    {
        protected MVC5AJ1ApiControllerBase()
        {
            LocalizationSourceName = MVC5AJ1Consts.LocalizationSourceName;
        }
    }
}