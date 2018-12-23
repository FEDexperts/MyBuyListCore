using MyBuyListDataAccess;
using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    public class LoginInfo
    {
        public string userName { get; set; }
        public string password { get; set; }
    };

    [RoutePrefix("api/auth")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AuthController : ApiController
    {
        [HttpGet]
        [Route("hello")]
        public string Hello()
        {
            return "Hello World";
        }

        [HttpPost]
        [Route("login")]
        public string Login([FromBody]LoginInfo login)
        {
            using(MyBuyListEntities entities = new MyBuyListEntities())
            {
                 User user = entities.Users.FirstOrDefault( p => p.Name == login.userName && p.Password == login.password);
                if (user != null)
                {
                    Globals.UserId = user.UserId;
                    string token = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", login.userName, login.password)));

                    user.Token = token;
                    entities.SaveChanges();

                    return token;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
