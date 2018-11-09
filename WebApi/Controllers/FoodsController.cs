using MyBuyListDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FoodsController : ApiController
    {
        [HttpGet]
        public IEnumerable<FoodModel> List()
        {
            using(MyBuyListEntities entities = new MyBuyListEntities())
            {
                return entities.Foods.Select(item => new FoodModel
                {
                    FoodId = item.FoodId,
                    FoodName = item.FoodName
                }).ToList();
            }
        }

        [HttpGet]
        public FoodModel Single(int id)
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                Food food = entities.Foods.FirstOrDefault(item => item.FoodId == id);
                return new FoodModel
                {
                    FoodId = food.FoodId,
                    FoodName = food.FoodName
                };
            }
        }

        [HttpGet]
        public IEnumerable<FoodModel> Partial(string pre)
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                return entities.Foods
                    //.TakeWhile(item => item.FoodName.IndexOf(prefix) != -1)
                    .Select(item => new FoodModel
                    {
                        FoodId = item.FoodId,
                        FoodName = item.FoodName
                    }).ToList();
            }
        }

        [HttpGet]
        [Route("api/foods/search")]
        public Response Search(string searchValue)
        {
            try
            {
                using (MyBuyListEntities entities = new MyBuyListEntities())
                {
                    return new SuccessResponse
                    {
                        results = (from a in entities.Foods
                                   where a.FoodName.Contains(searchValue)
                                   select new FoodModel
                                   {
                                       FoodId = a.FoodId,
                                       FoodName = a.FoodName
                                   }).ToArray()
                    };
                }
            }
            catch(Exception e)
            {
                return new FailureResponse();
            }
        }
    }
}