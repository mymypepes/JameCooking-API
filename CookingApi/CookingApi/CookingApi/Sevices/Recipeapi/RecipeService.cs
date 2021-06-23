
using CookingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingApi.Sevices.Recipeapi
{
    public interface RecipeService
    {
        public List<Recipe> FindAll();
    }
}
