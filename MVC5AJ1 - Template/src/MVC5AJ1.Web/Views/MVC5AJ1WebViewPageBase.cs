using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace MVC5AJ1.Web.Views
{
    public abstract class MVC5AJ1WebViewPageBase : MVC5AJ1WebViewPageBase<dynamic>
    {
       
    }

    public abstract class MVC5AJ1WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected MVC5AJ1WebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = MVC5AJ1Consts.LocalizationSourceName;
        }
    }
}