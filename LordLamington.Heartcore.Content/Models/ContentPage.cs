using Microsoft.AspNetCore.Mvc;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;
using LordLamington.Heartcore.Content.Services;
using StazorPages.Heartcore.Extensions;
using StazorPages.Heartcore.Models;
using StazorPages.Heartcore.Models.Grid;
using StazorPages.Models;
using StazorPages.Routing;

namespace LordLamington.Heartcore.Content.Models
{
    [ModelBinder(typeof(RouteDataModelBinder))]
    public class ContentPage : HeartcorePage, IRetrievedContent
    {
        public const string ContentTypeAlias = "contentPage";

        public UmbracoGrid BodyText { get; set; }

        public string Title { get; set; }

        public CaaS.Image HeroImage { get; set; }

        public string GetContentTypeAlias() => ContentTypeAlias;

        public static ContentPage MapToType(CaaS.Content content)
        {
            return new ContentPage
            {
                Title = content.Value<string>("title"),
                BodyText = content.Value<UmbracoGrid>("bodyText"),
                HeroImage = content.Value<CaaS.Image>("heroImage"),
                Url = content.Url.ToSafeUrl(),
                Name = content.Name,
                isVisible = content.IsVisible()
            };

        }
    }
}
