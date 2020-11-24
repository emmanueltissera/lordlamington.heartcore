using System;
using System.Linq;
using System.Threading.Tasks;
using LordLamington.Heartcore.Content.Models;
using Microsoft.AspNetCore.Mvc;
using StazorPages.Heartcore;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;

namespace LordLamington.Heartcore.Content.ViewComponents
{
    public class ProductCollectionViewComponent : ViewComponent
    {
        private readonly HeartcoreCache _contentCache;

        public ProductCollectionViewComponent(HeartcoreCache contentCache)
        {
            _contentCache = contentCache ?? throw new ArgumentNullException(nameof(contentCache));
        }

        public async Task<IViewComponentResult> InvokeAsync(CaaS.Content productRoot = null)
        {
            var isCollectionPage = true;
            if (productRoot == null)
            {
                var productRootPaged = await _contentCache.GetByType(ProductCollection.ContentTypeAlias, "en-US");
                productRoot = productRootPaged.Content.Items.FirstOrDefault();
                isCollectionPage = false;
            }

            if (productRoot == null)
            {
                throw new Exception("Product Root is null");
            }

            var productCollection = ProductCollection.MapToType(productRoot);

            var children = await _contentCache.GetChildren(productRoot.Id, "en-US");

            productCollection.IsCollectionPage = isCollectionPage;
            productCollection.Products = children.Content.Items.Select(p => Product.MapToType(p));

            return View(productCollection);
        }
    }
}
