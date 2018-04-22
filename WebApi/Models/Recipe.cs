using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class RecipeModel
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public List<IngrediantModel> Ingrediants { get; set; }
        public string PreparationMethod { get; set; }
    }
}