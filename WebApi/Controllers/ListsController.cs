using MyBuyListDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Classes;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class DataModel
    {
        public int foodId;
        public int value;
    }

    public enum ListType
    {
        missing,
        shopping
    }

    [BasicAuth]
    [RoutePrefix("api/lists")]
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class ListsController : ApiController
    {
        [HttpGet]
        [Route("hello")]
        public string HelloWorld()
        {
            try
            {
                return "Hello World";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        [Route("{listType}")]
        public Response GetAll(string listType)
        {
            try
            {
                List list = null;

                switch (listType)
                {
                    case "missing":
                        list = new Missing();
                        break;
                    case "shopping":
                        list = new Shopping();
                        break;
                }

                return new SuccessResponse<ListModel[]>
                {
                    results = list.GetAll()
                };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet]
        [Route("{listType}/{foodId}")]
        public ListModel GetSingle(string listType, int foodId)
        {
            try
            {
                List list = null;

                switch (listType)
                {
                    case "missing":
                        list = new Missing();
                        break;
                    case "shopping":
                        list = new Shopping();
                        break;
                }

                return list.GetSingle(foodId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        [Route("{listType}")]
        public Response Add(string listType, [FromBody] ListModel body)
        {
            try
            {
                List list = null;

                switch (listType)
                {
                    case "missing":
                        list = new Missing();
                        break;
                    case "shopping":
                        list = new Shopping();
                        break;
                }

                list.Add(body);
                return new SuccessResponse<ListModel[]>
                {
                    results = list.GetAll()
                };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        [Route("{listType}/{foodId}")]
        public Response Update(string listType, int foodId, [FromBody] ListModel body)
        {
            try
            {
                List list = null;

                switch (listType)
                {
                    case "missing":
                        list = new Missing();
                        break;
                    case "shopping":
                        list = new Shopping();
                        break;
                }

                list.update(foodId, body);
                return new SuccessResponse<ListModel[]>
                {
                    results = list.GetAll()
                };
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        }

        [HttpPatch]
        [Route("{listType}/{foodId}")]
        public Response PartialUpdate(string listType, int foodId, [FromBody] ListModel body)
        {
            try
            {
                List list = null;

                switch (listType)
                {
                    case "missing":
                        list = new Missing();
                        break;
                    case "shopping":
                        list = new Shopping();
                        break;
                }

                return new SuccessResponse<ListModel>
                {
                    results = list.partialUpdate(foodId, body)
                };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        [HttpDelete]
        [Route("{listType}/{foodId}")]
        public Response Delete(string listType, int foodId)
        {
            try
            {
                List list = null;

                switch (listType)
                {
                    case "missing":
                        list = new Missing();
                        break;
                    case "shopping":
                        list = new Shopping();
                        break;
                }

                list.Delete(foodId);
                return new SuccessResponse<ListModel[]>
                {
                    results = list.GetAll()
                };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
