﻿using MyBuyListDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.Models;

namespace MyBuyListWebApi.Controllers
{
    public class RecipesController : ApiController
    {
        [HttpGet]
        public IEnumerable<RecipeModel> All()
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                return entities.Recipes.Select(r => new RecipeModel
                {
                    RecipeId = r.RecipeId,
                    RecipeName = r.RecipeName
                }).ToList();
            }
        }

        [HttpGet]
        public IEnumerable<RecipeModel> ByName(string id)
        {
            using (MyBuyListEntities entities = new MyBuyListEntities())
            {
                return entities.Recipes.Where(p => p.RecipeName.Contains(id)).Select(r => new RecipeModel
                {
                    RecipeId = r.RecipeId,
                    RecipeName = r.RecipeName
                }).ToList();
            }
        }

        [HttpGet]
        public RecipeModel ById(int id)
        {
            try
            {
                using (MyBuyListEntities entities = new MyBuyListEntities())
                {
                    IQueryable<Ingredient> ingredient = entities.Ingredients.Where(p => p.RecipeId == id);

                    List<IngrediantModel> ingModelList = new List<IngrediantModel>();
                    ingredient.ToList().ForEach(p =>
                    {
                        ingModelList.Add(new IngrediantModel
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
