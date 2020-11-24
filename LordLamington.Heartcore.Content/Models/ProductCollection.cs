﻿using Microsoft.AspNetCore.Mvc;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;
using System.Collections.Generic;
using LordLamington.Heartcore.Content.Services;
using StazorPages.Heartcore.Extensions;
using StazorPages.Heartcore.Models;
using StazorPages.Models;
using StazorPages.Routing;

namespace LordLamington.Heartcore.Content.Models
{
    [ModelBinder(typeof(RouteDataModelBinder))]
    public class ProductCollection : HeartcorePage, IRetrievedContent
    {
        public const string ContentTypeAlias = "productCollection";

        public ProductCollection()
        {

        }

        public string SubTitle { get; set; }

        public string Title { get; set; }

        public bool IsCollectionPage { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public string GetContentTypeAlias() => ContentTypeAlias;

        public static ProductCollection MapToType(CaaS.Content content)
        {
            return new ProductCollection
            {
                Title = content.Value<string>("title"),
                SubTitle = content.Value<string>("subTitle"),
                Url = content.Url.ToSafeUrl(),
                Name = content.Name,
                isVisible = content.IsVisible()
            };
        }

    }
}
