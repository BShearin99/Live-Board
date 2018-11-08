using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace LiveBoard.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {

        }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

       

        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }

        //public virtual ICollection<Image> Images { get; set; }
        //public virtual ICollection<Notes> Notes { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        //public virtual ICollection<UserClass> UserClasses { get; set; }



    }
}
