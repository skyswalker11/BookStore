using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore.Models.ViewModels;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //private BookContext context { get; set; }

        //public HomeController(BookStoreContext temp)
        //{
        //    context = temp;
        //}
        //public HomeController(BookContext temp) => context = temp;

        private IBookStoreRepository repo;

        public HomeController (IBookStoreRepository temp)
        {
            repo = temp;
        }
        public IActionResult Index(int pageNum = 1)
        {

            int pageSize = 10;

            var x = new BooksViewModel
            {
                FormResponses = repo.FormResponses
                .OrderBy(r => r.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),
                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.FormResponses.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };              

            return View(x);
        }
    }
}
