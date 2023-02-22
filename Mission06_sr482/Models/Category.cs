using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_sr482.Models
{
    // Category Model
    public class Category
    { 
        [Key]
        [Required]
        public int CategoryID { set; get; }
        public string CategoryName { set; get; }
    }
}
