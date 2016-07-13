using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using SimpleCommerce.Infrastructure.Domain.IRepositories;
using SimpleCommerce.Core.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SimpleCommerce.Web.RouteConfigs
{
    public class GenericRule : IRouter
    {
        private readonly IRouter _target;

        public GenericRule(IRouter target)
        {
            _target = target;
        }

        public async Task RouteAsync(RouteContext context)
        {
            var requestPath = context.HttpContext.Request.Path.Value;
            if (!string.IsNullOrWhiteSpace(requestPath) && requestPath[0] == '/' )
            {
                requestPath = requestPath.Substring(1);
            }
            //var urlSlugRepository = context.HttpContext.RequestServices
            //    .GetService<IRepository<UrlSlug>>();

            //var urlSlug = await urlSlugRepository.Query().FirstOrDefault(
            //    x => x.Slug == requestPath);

            var oldRouteData = context.RouteData;
            var newRouteData = new RouteData(oldRouteData);
            newRouteData.Routers.Add(_target);

            //if (urlSlug == null)
            //{
            //    return;
            //}

            //switch (urlSlug.EntityName)
            //{
            //    case "Category":
            //        newRouteData.Values["controller"] = "Product";
            //        newRouteData.Values["action"] = "ProductsByCategory";
            //        newRouteData.Values["catSeoTitle"] = urlSlug.Slug;
            //        break;
            //    case "Product":
            //        newRouteData.Values["controller"] = "Product";
            //        newRouteData.Values["action"] = "ProductDetail";
            //        newRouteData.Values["seoTitle"] = urlSlug.Slug;
            //        break;
            //    case "Page":
            //        newRouteData.Values["controller"] = "Page";
            //        newRouteData.Values["action"] = "PageDetail";
            //        newRouteData.Values["id"] = urlSlug.EntityId;
            //        break;
            //}

            context.RouteData = newRouteData;
            await _target.RouteAsync(context);

        }

        public VirtualPathData GetVirtualPath(VirtualPathContext context)
        {
            return null;
        }
    }
}