using LordLamington.Heartcore.Content.Models;
using System;
using StazorPages.Heartcore.Resolvers;
using StazorPages.Models;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;

namespace LordLamington.Heartcore.Content.Resolvers
{
    public class TypeResolver : ITypeResolver
    {
        public IRetrievedContent GetTypedContent(CaaS.Content content)
        {
            return content.ContentTypeAlias switch
            {
                Cafe.ContentTypeAlias => Cafe.MapToType(content),
                CafeCollection.ContentTypeAlias => CafeCollection.MapToType(content),
                ContentPage.ContentTypeAlias => ContentPage.MapToType(content),
                Home.ContentTypeAlias => Home.MapToType(content),
                Product.ContentTypeAlias => Product.MapToType(content),
                ProductCollection.ContentTypeAlias => ProductCollection.MapToType(content),
                _ => throw new TypeLoadException($"Unknown type {content.ContentTypeAlias} encountered.")
            };
        }
    }
}
