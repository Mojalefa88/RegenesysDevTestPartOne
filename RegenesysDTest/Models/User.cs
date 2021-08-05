using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RegenesysDTest.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Display(Name ="First Name")]
        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter ID number/Passport")]
        [Display(Name = "ID Number/Passport")]
        public string IDNumber { get; set; }

        [Display(Name ="Nationality")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Email is not valid")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Country Code")]
        public string CountryCode { get; set; }

        [Display(Name = "Phone Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Phone Number is invalid.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Date of birth")]
        public string DOB { get; set; } 

        [Display(Name = "Date")]
        public DateTime DateStamp { get; set; }
    }
}