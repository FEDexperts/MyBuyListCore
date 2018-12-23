using MyBuyListDataAccess;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("api/general")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GeneralController : ApiController
    {
        [HttpGet]
        [Route("units")]
        public Response GetUnits()
        {
            try
            {
                using (MyBuyListEntities entities = new MyBuyListEntities())
                {
                    return new SuccessResponse<UnitModel[]>
                    {
                        results = entities.MeasurementUnits.Select(item => new UnitModel
                        {
                            unitId = item.UnitId,
                            unitName = item.UnitName
                        }).ToArray()
                    };
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
