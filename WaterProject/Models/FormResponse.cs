using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//This page provides model configuration for working with the movie application form
namespace BookStore.Models
{
    public class FormResponse
    {
        [Key]
        [BindNever]
        public int BookId { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "ISBN is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        public int NumPage { get; set; }
        [Required(ErrorMessage = "NumPage is Required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Author is Required")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "Publisher is Required")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Price is Required")]

        //Build FK relationship
        //[Required(ErrorMessage = "Category is Required")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Category is Required")]
        //public Category Category { get; set; }

        public string Classification { get; set; }
        //[Required(ErrorMessage = "Classification is Required")]
        //public Classification Classification { get; set; }
    }
}