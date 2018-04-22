using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class IngrediantModel
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Measure { get; set; }
    }
}