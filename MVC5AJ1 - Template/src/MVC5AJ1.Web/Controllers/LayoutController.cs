﻿using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Configuration;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Runtime.Session;
using Abp.Threading;
using MVC5AJ1.Configuration;
using MVC5AJ1.Sessions;
using MVC5AJ1.Web.Models.Layout;
using MVC5AJ1.Web.Navigation;
using MVC5AJ1.Web.Session;

namespace MVC5AJ1.Web.Controllers
{
    /// <summary>
    /// Layout for 'front end' pages.
    /// </summary>
    public class LayoutController : MVC5AJ1ControllerBase
    {
        private readonly IPerRequestSessionCache _sessionCache;
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly IMultiTenancyConfig _multiTenancyConfig;
        private readonly ILanguageManager _languageManager;

        public LayoutController(
            IPerRequestSessionCache sessionCache, 
            IUserNavigationManager userNavigationManager, 
            IMultiTenancyConfig multiTenancyConfig,
            ILanguageManager languageManager)
        {
            _sessionCache = sessionCache;
            _userNavigationManager = userNavigationManager;
            _multiTenancyConfig = multiTenancyConfig;
            _languageManager = languageManager;
        }

        [ChildActionOnly]
        public PartialViewResult Header(string currentPageName = "")
        {
            var headerModel = new HeaderViewModel();
            
            if (AbpSession.UserId.HasValue)
            {
                headerModel.LoginInformations = AsyncHelper.RunSync(() => _sessionCache.GetCurrentLoginInformationsAsync());
            }

            headerModel.Languages = _languageManager.GetLanguages();
            headerModel.CurrentLanguage = _languageManager.CurrentLanguage;
            
            headerModel.Menu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync(FrontEndNavigationProvider.MenuName, AbpSession.ToUserIdentifier()));
            headerModel.CurrentPageName = currentPageName;

            headerModel.IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled;
            headerModel.TenantRegistrationEnabled = SettingManager.GetSettingValue<bool>(AppSettings.TenantManagement.AllowSelfRegistration);

            return PartialView("~/Views/Layout/_Header.cshtml", headerModel);
        }
    }
}