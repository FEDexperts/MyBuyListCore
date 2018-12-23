using MyBuyListDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;
using WebApi.Models;

namespace WebApi.Classes
{
    public interface IList
    {
        ListModel[] GetAll();
        ListModel GetSingle(int foodId);
        void Add(ListModel data);
        ListModel update(int foodId, ListModel data);
        ListModel partialUpdate(int foodId, ListModel data);
        bool Delete(int foodId);
    }

    public abstract class List : IList
    {
        public Dictionary<string, string> ListMapping = new Dictionary<string, string>()
        {
            { "itemId", "FOOD_ID" },
            { "itemName", "FOOD_NAME" },
            { "value", "QUANTITY" },
            { "itemUnit", "MEASUREMENT_NAME" },
            { "itemUnitId", "MEASURMENT_ID" }
        };

        public abstract void Add(ListModel data);

        public abstract bool Delete(int foodId);

        public abstract ListModel[] GetAll();

        public abstract ListModel GetSingle(int foodId);

        public abstract ListModel update(int foodId, ListModel data);

        public abstract ListModel partialUpdate(int foodId, ListModel data);
    }

    public class Missing : List
    {
        public override void Add(ListModel data)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int foodId)
        {
            throw new NotImplementedException();
        }

        public override ListModel[] GetAll()
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                var result = (from a in entities.MissingLists
                              join b in entities.MissingListDetails on a.ID equals b.LIST_ID
                              where a.CREATED_BY == Globals.UserId.Value
                              select new ListModel
                              {
                                  ownerId = a.CREATED_BY,
                                  itemId = b.Food.FoodId,
                                  itemName = b.Food.FoodName,
                                  itemUnit = b.MeasurementUnit.UnitName,
                                  value = b.QUANTITY
                              }).ToArray();
                return result;
            };
        }

        public override ListModel GetSingle(int foodId)
        {
            throw new NotImplementedException();
        }

        public override ListModel partialUpdate(int foodId, ListModel data)
        {
            throw new NotImplementedException();
        }

        public override ListModel update(int foodId, ListModel data)
        {
            throw new NotImplementedException();
        }
    }

    public class Shopping : List
    {
        public override void Add(ListModel data)
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                Food food = entities.Foods.Where(item => item.FoodId == data.itemId).SingleOrDefault();
                if (food != null)
                {
                    UserShoppingList _new = new UserShoppingList
                    {
                        FOOD_ID = food.FoodId,
                        FOOD_NAME = food.FoodName,
                        CATEGORY_ID = food.FoodCategoryId,
                        CATEGORY_NAME = food.FoodCategory.FoodCategoryName,
                        QUANTITY = 0,
                        USER_ID = Globals.UserId.Value,
                        ACTIVE = true,
                        CAN_DELETE = true
                    };
                    entities.UserShoppingLists.Add(_new);
                    entities.SaveChanges();
                }
            }
        }

        public override bool Delete(int foodId)
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                UserShoppingList list = entities.UserShoppingLists.SingleOrDefault(item => item.USER_ID == Globals.UserId && item.FOOD_ID == foodId);
                if (list != null)
                {
                    entities.UserShoppingLists.Remove(list);
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            };
        }

        public override ListModel[] GetAll()
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                return (from a in entities.UserShoppingLists
                        where a.USER_ID == Globals.UserId
                        select new ListModel
                        {
                            ownerId = a.USER_ID,
                            itemId = a.FOOD_ID,
                            itemName = a.FOOD_NAME,
                            itemUnit = a.MEASUREMENT_NAME,
                            itemUnitId = a.MEASURMENT_ID.Value,
                            value = a.QUANTITY.Value
                        }).ToArray();
            }
        }

        public override ListModel GetSingle(int foodId)
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                UserShoppingList list = entities.UserShoppingLists.SingleOrDefault(item => item.USER_ID == Globals.UserId.Value && item.FOOD_ID == foodId);
                if (list != null)
                {
                    return new ListModel
                    {
                        ownerId = Globals.UserId.Value,
                        itemId = list.FOOD_ID,
                        itemName = list.FOOD_NAME,
                        itemUnit = list.MEASUREMENT_NAME,
                        value = list.QUANTITY.Value
                    };
                }
                else
                {
                    return new ListModel();
                }
            }
        }

        public override ListModel partialUpdate(int foodId, ListModel data)
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                UserShoppingList list = entities.UserShoppingLists.FirstOrDefault(item => item.USER_ID == Globals.UserId.Value && item.FOOD_ID == foodId);

                List<PropertyInfo> listProperties = list.GetType().GetProperties().ToList();

                foreach (var dataProp in data.GetType().GetProperties())
                {
                    var dataPropValue = dataProp.GetValue(data);
                    if (dataPropValue != null && dataProp.Name != "version")
                    {
                        var listProp = listProperties.Find(item => item.Name == ListMapping[dataProp.Name]);
                        if (listProp != null)
                        {
                            listProp.SetValue(list, dataPropValue);
                        }
                    }
                }

                entities.SaveChanges();

                return new ListModel
                {
                    ownerId = Globals.UserId.Value,
                    itemId = list.FOOD_ID,
                    itemName = list.FOOD_NAME,
                    itemUnit = list.MEASUREMENT_NAME,
                    value = list.QUANTITY.Value
                };
            }
        }

        public override ListModel update(int foodId, ListModel data)
        {
            throw new NotImplementedException();
        }
    }
}
