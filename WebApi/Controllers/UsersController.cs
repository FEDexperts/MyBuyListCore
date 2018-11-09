using MyBuyListDataAccess;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using WebApi.Models;

namespace WebApi.Controllers
{
    //[Authorize]
    public class UsersController : ApiController
    {
        // GET: api/Users
        [HttpGet]
        public IEnumerable<UserModel> List()
        {
            using (MyBuyListEntities entities = new MyBuyListEntities()) 
            {
                return entities.Users.Select(item =>new UserModel
                {
                    Name = item.DisplayName,
                    Email = item.Email,
                    Password = item.Password
                }).ToList();
            } 
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
