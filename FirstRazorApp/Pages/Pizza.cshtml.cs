using FirstRazorApp.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstRazorApp.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {ImageTitle="Margerita",
             PizzaName="Margerita",
             BasePrice=2,
             TomatoSauce=true,
             Cheese=true,
             FinalPrice = 3.5f},

            new PizzasModel()
            {ImageTitle="Bolognese",
             PizzaName="Bolognese",
             BasePrice=2,
             TomatoSauce=true,
             Cheese=true,
             Beef=true,
             FinalPrice = 3.8f},

            new PizzasModel()
            {ImageTitle="Hawaiian",
             PizzaName="Hawaiian",
             BasePrice=2,
             TomatoSauce=true,
             Cheese=true,
             Ham=true,
             Pineapple=true,
             FinalPrice = 4.5f},

            new PizzasModel()
            {ImageTitle="Carbonara",
             PizzaName="Carbonara",
             BasePrice=2,
             TomatoSauce=true,
             Cheese=true,
             Ham=true,
             Mushroom=true,
             FinalPrice = 3.5f},

            new PizzasModel()
            {ImageTitle="MeatFeast",
             PizzaName="MeatFeast",
             BasePrice=2,
             TomatoSauce=true,
             Cheese=true,
             Beef=true,
             FinalPrice = 3.8f},

            new PizzasModel()
            {ImageTitle="Mushroom",
             PizzaName="Mushroom",
             BasePrice=2,
             TomatoSauce=true,
             Cheese=true,
             Mushroom=true,
             FinalPrice = 3.2f},

            new PizzasModel()
            {ImageTitle="Pepperoni",
             PizzaName="Pepperoni",
             BasePrice=2,
             TomatoSauce=true,
             Cheese=true,
             Peperoni=true,
             FinalPrice = 3.7f},

            new PizzasModel()
            {ImageTitle="Seafood",
             PizzaName="Seafood",
             BasePrice=2,
             TomatoSauce=true,
             Cheese=true,
             Tuna=true,
             FinalPrice = 4.1f},

            new PizzasModel()
            {ImageTitle="Vegetarian",
             PizzaName="Vegetarian",
             BasePrice=2,
             TomatoSauce=true,
             Cheese=true,
             Mushroom=true,
             Pineapple=true,
             FinalPrice = 3.6f},
        };
        public void OnGet()
        {
        }
    }
}
