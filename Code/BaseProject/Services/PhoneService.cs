using System.Collections.Generic;
using System.Linq;
using BaseProject.Web.DAL;
using BaseProject.Web.Models;

namespace BaseProject.Web.Services
{
    public class PhoneService
    {
        private readonly DatabaseContext db = new DatabaseContext();

        public List<Phone> GetAllPhones()
        {
            return db.Phones.ToList();
        }

        public Phone GetById(int id)
        {
            return id == 0
                ? new Phone
                {
                    Id = 0
                }
                : db.Phones.FirstOrDefault(x => x.Id.Equals(id));
        }

        public Phone SavePhone(Phone phone)
        {
            if (phone.Id == 0)
            {
                db.Phones.Add(phone);
            }
            else
            {
                var newItem = GetById(phone.Id);
                newItem.Title = phone.Title;
                newItem.Html = phone.Html;
                db.Entry(newItem);
            }
            db.SaveChanges();
            return phone;
        }

        public void DeletePhone(int id)
        {
            throw new System.NotImplementedException();
        }

        public void PutPhone(int id, string value)
        {
            throw new System.NotImplementedException();
        }

        public void PostPhone(string value)
        {
            throw new System.NotImplementedException();
        }
    }
}