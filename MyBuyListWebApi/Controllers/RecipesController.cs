using System;
using System.Collections.Generic;
using System.Linq;
using MyBuyListDataAccess;
using System.Web.Http;

namespace MyBuyListWebApi.Controllers
{
    public class IngedientModel
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Measure { get; set; }
    }

    public class RecipeModel
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public List<IngedientModel> Ingrediants { get; set; }
        public string PreparationMethod { get; set; }
    }

    public class RecipesController : ApiController
    {
        public IEnumerable<RecipeModel> Get()
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                return entities.Recipes.Select(r => new RecipeModel
                {
                    RecipeId = r.RecipeId,
                    RecipeName = r.RecipeName
                }).Take(10).ToList();
            }
        }

        public RecipeModel Get(int id)
        {
            try
            {
                using (MyBuyListEntities entities = new MyBuyListEntities())
                {
                    IQueryable<Ingredient> ingredient = entities.Ingredients.Where(p => p.RecipeId == id);

                    List<IngedientModel> ingModelList = new List<IngedientModel>();
                    ingredient.ToList().ForEach(p =>
                    {
                        ingModelList.Add(new IngedientModel
                        {
                            Name = p.Food.FoodName,
                            Measure = p.MeasurementUnit.UnitName,
                            Quantity = p.Quantity
                        });
                    });

                    Recipe recipe = entities.Recipes.FirstOrDefault(r => r.RecipeId == id);
                    if (recipe != null)
                    {
                        return new RecipeModel
                        {
                            RecipeId = recipe.RecipeId,
                            RecipeName = recipe.RecipeName,
                            Ingrediants = ingModelList,
                            PreparationMethod = recipe.PreparationMethod
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
