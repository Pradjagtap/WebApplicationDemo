using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Rollno is required")]
        public int RollNo { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(minimum: 18, maximum: 30, ErrorMessage = "Age must be between 18-30")]
        [Display(Name = "Student Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        //in password if we have to give - include some character numbers and special
        //character and having length 8
        //use regular expression same as email u can get regular expression on google
        //with different formats
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "Password does not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


    }
}
