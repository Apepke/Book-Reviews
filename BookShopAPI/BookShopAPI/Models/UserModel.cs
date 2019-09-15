using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShopAPI.Models
{
    public class UserModel
    {
       [Required(ErrorMessage="You need to enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to enter a title name.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You need to enter an author.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "You need to write a review.")]
        [StringLength(200, MinimumLength =10, ErrorMessage = "You need to provide a longer review.")]
        public string Review { get; set; }
        public int Id { get; set; }
    }
}