using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Recipes.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }

        public string Ingredients { get; set; }

        public string BakingInstructions { get; set; }

        public string Amount { get; set; }

        public int Rating { get; set; }

    }
}