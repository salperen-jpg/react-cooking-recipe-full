using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Recipe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : Controller
    {
        [HttpGet("getallrecipe")]
        public IActionResult Index()
        {
            List<Recipe> recipeList = Recipe.GetAllRecipe();
            return Ok(recipeList);

        }
    }
}
