using MyBuyListDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DataModel
    {
        public int foodId;
        public int value;
    }

    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class ListsController : ApiController
    {
        [HttpGet]
        [Route("api/lists/missing/{listId}")]
        public Response Missing(int listId)
        {
            try
            {
                using (MyBuyListEntities entities = new MyBuyListEntities())
                {
                    return new SuccessResponse
                    {
                        results = (from a in entities.MissingLists
                                   join b in entities.MissingListDetails on a.ID equals b.LIST_ID
                                   where a.ID == listId
                                   select new ListModel
                                   {
                                       listId = a.ID,
                                       ownerId = a.CREATED_BY,
                                       itemId = b.Food.FoodId,
                                       itemName = b.Food.FoodName,
                                       itemUnit = b.MeasurementUnit.UnitName,
                                       value = b.QUANTITY
                                   }).ToArray()
                    };
                }
            }
            catch (Exception e)
            {
                return new FailureResponse();
            }
        }

        [HttpGet]
        [Route("api/lists/missing/{listId}/{foodId}")]
        public Response SingleMissing(int listId, int foodId)
        {
            try
            {
                using (MyBuyListEntities entities = new MyBuyListEntities())
                {
                    return new SuccessResponse
                    {
                        results = (from a in entities.MissingLists
                                join b in entities.MissingListDetails on a.ID equals b.LIST_ID
                                where a.ID == listId && b.Food.FoodId == foodId
                                select new ListModel
                                {
                                    listId = a.ID,
                                    ownerId = a.CREATED_BY,
                                    itemId = b.Food.FoodId,
                                    itemName = b.Food.FoodName,
                                    itemUnit = b.MeasurementUnit.UnitName
                                }).ToArray()
                    };
                }
            }
            catch (Exception e) {
                return new FailureResponse();
            }
        }

        [HttpPost]
        [Route("api/lists/missing/{listId}")]
        public Response AddItem(int listId, [FromBody] DataModel body )
        {
            try
            {
                using (MyBuyListEntities entities = new MyBuyListEntities())
                {
                    Food food = entities.Foods.Where(item => item.FoodId == body.foodId).SingleOrDefault();
                    if (food != null)
                    {
                        MissingListDetail _new = new MissingListDetail
                        {
                            LIST_ID = listId,
                            FOOD_ID = body.foodId
                        };
                        entities.MissingListDetails.Add(_new);
                        entities.SaveChanges();

                        ListModel[] result = new ListModel[]
                        {
                            new ListModel {
                                listId = listId,
                                    itemId = food.FoodId,
                                    itemName = food.FoodName
                            }
                        };

                        return new SuccessResponse
                        {
                            results = result
                        };
                    }
                    else
                    {
                        return new FailureResponse();
                    }
                }
            }
            catch (Exception e)
            {
                return new FailureResponse
                {
                    message = e.Message,
                    innerMessage = e.InnerException?.Message
                };
            }
        }

        [HttpPut]
        [Route("api/lists/missing/{listId}/{foodId}")]
        public Response UpdateMissingItem(int listId, int foodId, [FromBody] DataModel body)
        {
            try
            {
                using (MyBuyListEntities entities = new MyBuyListEntities())
                {
                    MissingListDetail list = entities.MissingListDetails.FirstOrDefault(item => item.LIST_ID == listId && item.FOOD_ID == foodId);
                    list.QUANTITY = body.value;
                    entities.SaveChanges();

                    return new SuccessResponse { };
                }
            }
            catch (Exception e) {
                return new FailureResponse();
            }
        }

        [HttpDelete]
        [Route("api/lists/missing/{listId}/{foodId}")]
        public Response DeleteItem(int listId, int foodId)
        {
            try
            {
                using (MyBuyListEntities entities = new MyBuyListEntities())
                {
                    MissingListDetail list = entities.MissingListDetails.SingleOrDefault(item => item.LIST_ID == listId && item.FOOD_ID == foodId);
                    if (list != null)
                    {
                        entities.MissingListDetails.Remove(list);
                        entities.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("No item found");
                    }

                    return new SuccessResponse
                    {
                        results = (from a in entities.MissingLists
                                   join b in entities.MissingListDetails on a.ID equals b.LIST_ID
                                   where a.ID == listId
                                   select new ListModel
                                   {
                                       listId = a.ID,
                                       ownerId = a.CREATED_BY,
                                       itemId = b.Food.FoodId,
                                       itemName = b.Food.FoodName,
                                       itemUnit = b.MeasurementUnit.UnitName,
                                       value = b.QUANTITY
                                   }).ToArray()
                    };
                }
            }
            catch (Exception e)
            {
                return new FailureResponse
                {
                    message = e.Message
                };
            }
        }
    }
}
