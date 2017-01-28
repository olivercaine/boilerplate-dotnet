using System.Collections.Generic;
using System.Linq;
using BaseProject.Web.Models;
using BaseProject.Web.Utilities;

namespace BaseProject.Web.Services
{
    public class SitemapService
    {
        private readonly PhoneService phoneService = new PhoneService();

        public IList<string> SitemapUrls()
        {
            return
                phoneService.GetAllPhones()
                    .Select(item => string.Concat(Urls.AbsoluteUri, item.Title.GenerateSlug()).ToLower())
                    .ToList();
        }

        public IList<SitemapItem> SitemapPages()
        {
            var list = new List<SitemapItem>();
            foreach (var phone in phoneService.GetAllPhones())
            {
                var sm = new SitemapItem
                {
                    Url = string.Concat(Urls.AbsoluteUri, "phone-info/", phone.Title.GenerateSlug()),
                    Title = phone.Title
                };
                list.Add(sm);
            }
            return list;
        }
    }
}