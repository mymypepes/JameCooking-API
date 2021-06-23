
using CookingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingApi.Sevices.Recipeapi
{

    public class RecipeServiceImpl : RecipeService
    {
        private DatabaseContext Db;


        public RecipeServiceImpl(DatabaseContext _Db)
        {
            Db = _Db;
        }
        public List<Recipe> FindAll()
        {
            return (from recipe in Db.Recipes
                    select recipe).ToList();
        }


    }
}
