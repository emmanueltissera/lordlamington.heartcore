using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;
using StazorPages.Heartcore.Extensions;
using LordLamington.Heartcore.Content.Services;
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
            return new CafeCollection
            {
                Title = content.Value<string>("title"),
                BodyText = content.Value<string>("bodyText"),
                Url = content.Url.ToSafeUrl(),
                Name = content.Name,
                isVisible = content.IsVisible()
            };

        }
    }
}
