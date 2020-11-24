using StazorPages.Models;

namespace LordLamington.Heartcore.Content.ViewModels
{
    public class ErrorViewModel : IRetrievedContent
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Title { get; set; } = "Error";
        public string Url { get; set; } = "error";

        public string GetContentTypeAlias() => "error";

        public string StatusCode { get; set; }
    }
}
