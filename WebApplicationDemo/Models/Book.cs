using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class Book
    {
        [Required(ErrorMessage = "id is required")]
        public int id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display (Name ="Book Name")]
        public string name{ get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "Price must be between 1-10000")]
        [Display(Name = "Book price")]
        public int price { get; set; }


    }
}
