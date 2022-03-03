using Microsoft.AspNetCore.Mvc;
using BookStore.Models;


namespace BookStore.Components
{
    public class BasketSummaryViewComponent : ViewComponent 
    {
        private Basket basket;
        public BasketSummaryViewComponent (Basket basketService)
        {
            basket = basketService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
