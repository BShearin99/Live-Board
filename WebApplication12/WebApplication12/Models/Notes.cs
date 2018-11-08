using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiveBoard.Models
{
    public class Notes
    {

        [Key]
        public int NoteId { get; set; }



       
      public byte[] Img64 { get; set; }


        public string Text { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }

        //public virtual ICollection<Image> Images { get; set; }

    }
}
