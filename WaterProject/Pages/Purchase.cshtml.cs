using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Infrastructure;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages
{
    public class PurchaseModel : PageModel
    {

        private IBookStoreRepository repo { get; set; }

        public PurchaseModel (IBookStoreRepository temp)
        {
            repo = temp;
        }

        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(string isbn, string returnUrl)
        {
            FormResponse f = repo.FormResponses.FirstOrDefault(x => x.ISBN == isbn);

            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.AddItem(f, 1);

            HttpContext.Session.SetJson("basket", basket);

            return RedirectToPage(new { ReturnURL = returnUrl });
        }
    }
}
