using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class CategoryModel
    {
        [Key]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }
<<<<<<< Updated upstream
=======
        [Display(Name ="Category")]
        [Required]

        public string CategoryName { get; set; }
>>>>>>> Stashed changes

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}
