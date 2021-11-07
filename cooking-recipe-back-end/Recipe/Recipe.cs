using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe
{
    public class Recipe

    {
        public int Id { get;set;}
        public string Name { get; set; }
        public string Author { get; set; }
        public string Img { get; set; }
        public int Rating { get; set; }
        public static List<Recipe> GetAllRecipe()
        {
            List<Recipe> recipes = new List<Recipe>() {
            new Recipe() { Id = 1, Name = "Vichyssoise", Author = "Marie Claude",Img="https://assets.marthastewart.com/styles/wmax-750/d28/vichyssoie-recipe-0420-horiz/vichyssoie-recipe-0420-horiz.jpg?itok=hrF0jcej", Rating = 4 },
            new Recipe() { Id = 2, Name = "Beef Wellington", Author = "Robert Dinklage",Img="https://res.cloudinary.com/hksqkdlah/image/upload/SFS_20200513-BeefWellingtonSFS-1290_xwvdbx.jpg", Rating = 5 },
            new Recipe() { Id = 3, Name = "Caesar Salad", Author = "Hans Peter",Img="https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/36E4DDF2-5FA5-4FDD-BEF2-336F8DD05258/Derivates/37fba9c7-aebf-43f9-b551-0b4b70ab2d17.jpg" ,Rating = 2 },
            new Recipe() { Id = 4, Name = "Duck l'Orange", Author = "Daniel Frederick",Img="https://assets.epicurious.com/photos/576426e44e0b8d1a3dcc5f39/master/pass/duck-a-lorange.jpg", Rating = 1 },
            new Recipe() { Id = 5, Name = "Strawberries with Cream", Author = "Hans Peter",Img="https://www.tastesoflizzyt.com/wp-content/uploads/2015/03/strawberries-and-cream-mini-parfaits-4.jpg", Rating = 1 },
            new Recipe() { Id = 6, Name = "Trifle", Author = "Donald McDouglas",Img="https://www.recipetineats.com/wp-content/uploads/2017/12/Christmas-Trifle-3-SQ.jpg", Rating = 3 },
            new Recipe() { Id = 7, Name = "Grilled Mushrooms with Cheese Topping", Author = "Laura Engel",Img="https://hips.hearstapps.com/hmg-prod/images/delish-190731-stuffed-portobello-mushrooms-0280-landscape-pf-1565820911.jpg", Rating = 4 },
            new Recipe() { Id = 8, Name = "Lamb Chops with Roast Potatoes", Author = "Julien Oliver",Img="https://i.dailymail.co.uk/i/pix/2009/11/12/article-0-07314EC2000005DC-815_468x458.jpg" ,Rating = 5 },
            new Recipe() { Id = 9, Name = "Black Pudding", Author = "Penelope Kennedy",Img="https://www.campbellsmeat.com/images/products/verylarge/1517585106StornowayBlackPuddingRoll.jpg", Rating = 3 },
            new Recipe() { Id = 10, Name = "Homemade Yorkshire Pudding", Author = "Teddy Dunphy",Img="https://www.seriouseats.com/thmb/x_dpMwJQL47ja3md7ovVoNA0jos=/1500x844/smart/filters:no_upscale()/__opt__aboutcom__coeus__resources__content_migration__serious_eats__seriouseats.com__recipes__images__2015__12__20151202-popover-yorkshire-pudding-food-lab-recipe-kenji-22-13c9d93cdcc947089d25bf9a2e880f64.jpg", Rating = 5 }
            };
            return recipes;

        }
    }
}
