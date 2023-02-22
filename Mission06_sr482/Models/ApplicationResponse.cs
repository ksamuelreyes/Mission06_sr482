using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_sr482.Models
{
    // Model for movies
    public class ApplicationResponse
    {
        // Movie characteristics w/ validation
        [Key]
        [Required]
        public int MovieID { get; set; }

        //[Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        //[Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }

        //[Required(ErrorMessage = "Director is required")]
        public string Director { get; set;}

        //[Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent { get; set; }

        //[StringLength(25, ErrorMessage ="Notes length must be less than 25")]
        public string Notes { get; set; }

        // FK relationship
        //[Required(ErrorMessage = "Category is required")]

        public int CategoryID { get; set; }
        public Category Category { get; set; }



    }
}
