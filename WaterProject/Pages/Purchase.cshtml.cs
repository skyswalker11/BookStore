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

        public PurchaseModel (IBookStoreRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(string isbn, string returnUrl)
        {
            FormResponse f = repo.FormResponses.FirstOrDefault(x => x.ISBN == isbn);

            basket.AddItem(f, 1);

            return RedirectToPage(new { ReturnURL = returnUrl });
        }
        
        public IActionResult OnPostRemove(string ISBN, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.FormResponse.ISBN == ISBN).FormResponse);

            return RedirectToPage(new {ReturnUrl = returnUrl});
        }
    }
}
