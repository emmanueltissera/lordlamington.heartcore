using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;
using StazorPages.Heartcore.Extensions;
using StazorPages.Heartcore.Models;
using StazorPages.Models;
using StazorPages.Routing;

namespace LordLamington.Heartcore.Content.Models
{
    [ModelBinder(typeof(RouteDataModelBinder))]
    public class CafeCollection : HeartcorePage, IRetrievedContent
    {
        public const string ContentTypeAlias = "cafeCollection";

        public string BodyText { get; set; }

        public string Title { get; set; }

        public bool IsCollectionPage { get; set; }

        public IEnumerable<Cafe> Cafes { get; set; }

        public string GetContentTypeAlias() => ContentTypeAlias;

        public static CafeCollection MapToType(CaaS.Content content)
        {
            var model = new CafeCollection
            {
                Title = content.Value<string>("title"),
                BodyText = content.Value<string>("bodyText"),
            };
            model.MapCommonProperties(content);
            return model;
        }
    }
}
