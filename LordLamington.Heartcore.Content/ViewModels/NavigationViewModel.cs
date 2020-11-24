using LordLamington.Heartcore.Content.Models;
using System.Collections.Generic;

namespace LordLamington.Heartcore.Content.ViewModels
{
    public class NavigationViewModel
    {
        public IEnumerable<NavigationItem> NavigationItems { get; set; }

        public Home Root { get; set; }

        public bool IsHomePage { get; set; }
    }
}
