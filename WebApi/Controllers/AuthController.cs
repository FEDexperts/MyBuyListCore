using MyBuyListDataAccess;
using System.Linq;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class LoginInfo
    {
        public string userName { get; set; }
        public string password { get; set; }
    };

    public class AuthController : ApiController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World";
        }

        [HttpPost]
        public bool Login([FromBody]LoginInfo login)
        {
            using(MyBuyListEntities entities = new MyBuyListEntities())
            {
                User user = entities.Users.FirstOrDefault( p => p.Name == login.userName && p.Password ==login.password);
                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
