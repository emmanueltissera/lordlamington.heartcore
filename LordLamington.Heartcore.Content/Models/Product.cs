using Microsoft.AspNetCore.Mvc;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;
using Microsoft.AspNetCore.Html;
using StazorPages.Heartcore.Extensions;
using StazorPages.Heartcore.Models;
using StazorPages.Models;
using StazorPages.Routing;

namespace LordLamington.Heartcore.Content.Models
{
    [ModelBinder(typeof(RouteDataModelBinder))]
    public class Product : HeartcorePage, IRetrievedContent
    {
        public const string ContentTypeAlias = "product";

        public Product()
        {

        }

        public decimal Price { get; set; }

        public string Title { get; set; }

        public IHtmlContent Description { get; set; }

        public CaaS.Image ProductImage { get; set; }

        public string GetContentTypeAlias() => ContentTypeAlias;

        public static Product MapToType(CaaS.Content content)
        {
            var model = new Product
            {
                Title = content.Value<string>("title"),
                Price = content.Value<decimal>("price"),
                Description = content.Value<IHtmlContent>("description"),
                ProductImage = content.Value<CaaS.Image>("productImage"),
            };
            model.MapCommonProperties(content);
            return model;
        }
    }
}
