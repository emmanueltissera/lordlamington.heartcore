using Microsoft.AspNetCore.Mvc;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;
using LordLamington.Heartcore.Content.Services;
using StazorPages.Heartcore.Extensions;
using StazorPages.Heartcore.Models;
using StazorPages.Models;
using StazorPages.Routing;

namespace LordLamington.Heartcore.Content.Models
{
    [ModelBinder(typeof(RouteDataModelBinder))]
    public class Cafe : HeartcorePage, IRetrievedContent
    {
        public const string ContentTypeAlias = "cafe";

        public string BuildingNumber { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string Suburb { get; set; }

        public string Postcode { get; set; }

        public string State { get; set; }

        public string Title { get; set; }

        public string GetContentTypeAlias() => ContentTypeAlias;

        public static Cafe MapToType(CaaS.Content content)
        {
            return new Cafe
            {
                Title = content.Name,
                BuildingNumber = content.Value<string>("buildingNumber"),
                AddressLine1 = content.Value<string>("addressLine1"),
                AddressLine2 = content.Value<string>("addressLine2"),
                Suburb = content.Value<string>("suburb"),
                Postcode = content.Value<string>("postcode"),
                State = content.Value<string>("state"),
                Url = content.Url.ToSafeUrl(),
                Name = content.Name,
                isVisible = content.IsVisible()
            };

        }
    }
}
