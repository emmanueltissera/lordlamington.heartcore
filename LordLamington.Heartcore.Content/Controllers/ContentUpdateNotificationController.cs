using LordLamington.Heartcore.Content.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using StazorPages.Constants;
using StazorPages.Heartcore.Models;
using StazorPages.Models;
using StazorPages.Services;
using StazorPages.StazorFile;

namespace LordLamington.Heartcore.Content.Controllers
{
    [ApiController]
    [Route("api/contentupdate")]
    public class ContentUpdateNotificationController : ControllerBase
    {
        private readonly IContentService _contentService;
        public ContentUpdateNotificationController(IContentService contentService)
        {
            _contentService = contentService;
        }

        [HttpPost]
        public NotificationResult Post([FromBody] HeadlessNotification notification)
        {
            var pagePath = GetPagePath(notification.Id);
            StazorFileManagementService.DeletePage(pagePath);
            return new NotificationResult { Status = NotificationStatus.Success, Message = "Stazor page deleted successfully." };
        }

        private string GetPagePath(Guid id)
        {
            var item = _contentService.GetContentById(id).Result;
            var url = item.Url;
            return PageUrlTranslator.TranslateToStazorPath(url);
        }
    }
}
