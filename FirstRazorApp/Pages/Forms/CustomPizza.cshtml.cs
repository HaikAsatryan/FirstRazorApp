using FirstRazorApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstRazorApp.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 0.1f;
            if (Pizza.Cheese) PizzaPrice += 0.2f;
            if (Pizza.Peperoni) PizzaPrice += 0.5f;
            if (Pizza.Mushroom) PizzaPrice += 0.2f;
            if (Pizza.Tuna) PizzaPrice += 0.5f;
            if (Pizza.Pineapple) PizzaPrice += 0.5f;
            if (Pizza.Ham) PizzaPrice += 0.2f;
            if (Pizza.Beef) PizzaPrice += 0.4f;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}