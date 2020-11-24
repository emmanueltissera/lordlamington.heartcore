using System;
using System.Linq;
using System.Threading.Tasks;
using LordLamington.Heartcore.Content.Models;
using LordLamington.Heartcore.Content.ViewModels;
using Microsoft.AspNetCore.Mvc;
using StazorPages.Heartcore;
using StazorPages.Heartcore.Extensions;
using StazorPages.Heartcore.Services;
using CaaS = Umbraco.Headless.Client.Net.Delivery.Models;

namespace LordLamington.Heartcore.Content.ViewComponents
{
    public class MainNavigationViewComponent : ViewComponent
    {
        private readonly HeartcoreCache _contentCache;

        public MainNavigationViewComponent(HeartcoreCache contentCache)
        {
            _contentCache = contentCache ?? throw new ArgumentNullException(nameof(contentCache));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var rootContent = await _contentCache.GetContentByUrl("/", "en-US") as CaaS.Content;
            var homeNode = Home.MapToType(rootContent);
            var children = await _contentCache.GetChildren(rootContent.Id);

            var navItems = children.Content.Items.Where(x => x.IsVisible())
                .Select(item => new NavigationItem
                {
                    Title = item.Name, Url = item.Url.ToSafeUrl(), IsCurrent = item.Url == Request.Path.ToString()
                }).ToList();

            navItems.Insert(0, new NavigationItem { Title = homeNode.Title, Url = homeNode.Url, IsCurrent = homeNode.Url == Request.Path.ToString() });

            var navViewModel = new NavigationViewModel()
            {
                IsHomePage = rootContent.Url == Request.Path.ToString(),
                NavigationItems = navItems,
                Root = homeNode
            };

            return View(navViewModel);
        }
    }
}
