using System;
using System.Linq;
using System.Threading.Tasks;
using LordLamington.Heartcore.Content.Models;
using Microsoft.AspNetCore.Mvc;
using StazorPages.Heartcore;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;

namespace LordLamington.Heartcore.Content.ViewComponents
{
    public class CafeCollectionViewComponent : ViewComponent
    {
        private readonly HeartcoreCache _contentCache;

        public CafeCollectionViewComponent(HeartcoreCache contentCache)
        {
            _contentCache = contentCache ?? throw new ArgumentNullException(nameof(contentCache));
        }

        public async Task<IViewComponentResult> InvokeAsync(CaaS.Content cafeRoot = null)
        {
            var isCollectionPage = true;
            if (cafeRoot == null)
            {
                var productRootPaged = await _contentCache.GetByType(CafeCollection.ContentTypeAlias, "en-US");
                cafeRoot = productRootPaged.Content.Items.FirstOrDefault();
                isCollectionPage = false;
            }

            if (cafeRoot == null)
            {
                throw new Exception("Product Root is null");
            }

            var cafeCollection = CafeCollection.MapToType(cafeRoot);

            var children = await _contentCache.GetChildren(cafeRoot.Id, "en-US");

            cafeCollection.IsCollectionPage = isCollectionPage;
            cafeCollection.Cafes = children.Content.Items.Select(c => Cafe.MapToType(c));

            return View(cafeCollection);
        }
    }
}
