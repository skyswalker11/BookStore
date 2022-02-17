using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Classification
    {
        [Key]
        [Required]
        public int ClassificationID { get; set; }
        [Required]
        public string ClassificationName { get; set; }
    }
}
