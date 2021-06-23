using CookingApi.Sevices.Recipeapi;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingApi.Controllers
{
    [Route("cooking")]
    public class RecipeController : Controller
    {
        private RecipeService recipe;

        public RecipeController(RecipeService _recipe)
        {
            recipe = _recipe;
        }

        [Produces("application/json")]
        [HttpGet("recipefindall")]
        public IActionResult Index()
        {
            try
            {
                return Ok(recipe.FindAll());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
