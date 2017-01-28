using BaseProject.Web.Models;

namespace BaseProject.Web.ViewModels
{
    public class PhoneAdvertViewModel
    {
        public PhoneAdvertViewModel()
        {
            HasBuyBtn = true;
            Phone = new Phone {Title = "Default title", Html = "Default HTML", Id = 123};
        }

        public bool HasBuyBtn { get; set; }
        public Phone Phone { get; set; }
    }
}