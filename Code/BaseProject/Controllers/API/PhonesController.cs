using System.Collections.Generic;
using System.Web.Http;
using BaseProject.Web.Models;
using BaseProject.Web.Services;
using BaseProject.Web.Utilities;

namespace BaseProject.Web.Controllers.API
{
    /// <summary>
    /// A CRUD endpoint that manages phones
    /// </summary>
    [RoutePrefix("api/phones")]
    public class PhonesController : ApiController
    {
        private readonly PhoneService phoneService = new PhoneService();

        /// <summary>
        /// Gets a single phone
        /// </summary>
        [CacheControl]
        public Phone Get(int id)
        {
            return phoneService.GetById(id);
        }

        /// <summary>
        /// Creates a phone
        /// </summary>
        public void Post([FromBody]string value)
        {
            phoneService.PostPhone(value);
        }

        /// <summary>
        /// Updates a phone
        /// </summary>
        public void Put(int id, [FromBody]string value)
        {
            phoneService.PutPhone(id, value);
        }

        /// <summary>
        /// Deletes a phone
        /// </summary>
        public void Delete(int id)
        {
            phoneService.DeletePhone(id);
        }

        /// <summary>
        /// Returns all phones
        /// </summary>
        [HttpGet, Route("getall")]
        public IList<Phone> GetAll()
        {
            return phoneService.GetAllPhones();
        }
    }
}
