using System.Collections.Generic;
using SimpleCommerce.Web.ViewModels.Catalog;

namespace SimpleCommerce.Web.ViewModels
{
    public class HomeViewModel
    {
        public IList<ProductThumbnail> FeaturedProducts { get; set; } = new List<ProductThumbnail>();

        public IList<WidgetInstanceVm> WidgetInstances { get; set; } = new List<WidgetInstanceVm>();

    }
}