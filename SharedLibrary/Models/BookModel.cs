using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.Models
{

    public class BookModel
    {
        [Key]
<<<<<<< Updated upstream
        [Display(Name ="Book ID")]
        public int BookId { get; set; }
=======
        [Required]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }

        [Required]
>>>>>>> Stashed changes
        [Display(Name = "Book Name")]
        public string BookName { get; set; }

        [Display(Name = "Category")]
<<<<<<< Updated upstream
        public int CategoryId { get; set; }  //foreign key

        public string CategoryName { get; set; }    
=======
        [Required]
        [ForeignKey("tbl_CATEGORY")]
        public int CategoryId { get; set; }  //foreign key

        [Required]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
>>>>>>> Stashed changes

        public string Author { get; set; }

        public string Publisher { get; set; }

        [Required]

        public decimal Price { get; set; }

        public virtual CategoryModel CategoryModel { get; set; }   //nav prop
<<<<<<< Updated upstream
=======

        public List<CategoryModel> Categories { get; set; }

        public int Selected { get; set; }
>>>>>>> Stashed changes
    }
}
