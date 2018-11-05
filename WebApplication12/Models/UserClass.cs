using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiveBoard.Models
{
    public class UserClass
    {
        [Key]
        public int UserClassId { get; set; }


        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        public int ClassId { get; set; }

        public Class Class { get; set; }


        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
