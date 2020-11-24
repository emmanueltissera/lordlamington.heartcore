using Microsoft.AspNetCore.Mvc;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;
using StazorPages.Heartcore.Extensions;
using StazorPages.Heartcore.Models;
using StazorPages.Models;
using StazorPages.Routing;

namespace LordLamington.Heartcore.Content.Models
{
    [ModelBinder(typeof(RouteDataModelBinder))]
    public class Home : HeartcorePage, IRetrievedContent
    {
        public const string ContentTypeAlias = "home";

        public Home()
        {

        }

        public CaaS.Image BannerImage { get; set; }

        public string SubHeading { get; set; }

        public string Headline { get; set; }

        public string Title { get; set; }

        public string GetContentTypeAlias() => ContentTypeAlias;

        public static Home MapToType(CaaS.Content content)
        {
            var model = new Home
            {
                BannerImage = content.Value<CaaS.Image>("bannerImage"),
                Headline = content.Value<string>("headline"),
                SubHeading = content.Value<string>("subHeading"),
                Title = content.Name,
            };
            model.MapCommonProperties(content);
            return model;
        }
    }
}
