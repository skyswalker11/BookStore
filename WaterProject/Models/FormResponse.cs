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
        [Required]
        public string ISBN { get; set; }
        [Required(ErrorMessage ="ISBN is Required")]
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
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int ClassificationID { get; set; }
        public Classification Classification { get; set; }
    }
}