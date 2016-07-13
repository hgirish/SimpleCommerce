using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using SimpleCommerce.Core.Domain.Models;
using SimpleCommerce.Web.ViewModels;
using SimpleCommerce.Infrastructure.Domain.IRepositories;
using SimpleCommerce.Cms.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SimpleCommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<User> _userManager;
        private readonly IRepository<WidgetInstance> _widgetInstanceRepository;
        private readonly IStringLocalizer<HomeController> _localizer;
       // private IRepository<WidgetInstance> _widgetInstanceRepository;
        public HomeController(UserManager<User> userManager, IStringLocalizer<HomeController> localizer, IRepository<WidgetInstance> widgetInstanceRepository)
        {
            _userManager = userManager;
            _localizer = localizer;
            _widgetInstanceRepository = widgetInstanceRepository;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();

            var widgetInstances = _widgetInstanceRepository.Query()
                .Include(x => x.Widget)
                .Where(x => x.WidgetZoneId == WidgetZoneIds.HomeFeatured
                            || x.WidgetZoneId == WidgetZoneIds.HomeMainContent
                            || x.WidgetZoneId == WidgetZoneIds.HomeAfterMainContent);

            model.WidgetInstances = widgetInstances.Select(
                x => new WidgetInstanceVm
                {
                    Id = x.Id,
                    Name = x.Name,
                    ViewComponentName = x.Widget.ViewComponentName,
                    WidgetId = x.WidgetId,
                    WidgetZoneId = x.WidgetZoneId,
                    Data = x.Data,
                    HtmlData = x.HtmlData
                }).ToList();
            return View(model);
           
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(culture)),
                new Microsoft.AspNetCore.Http.CookieOptions
                {
                    Expires = DateTime.UtcNow.AddYears(1)
                });

            return LocalRedirect(returnUrl);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
