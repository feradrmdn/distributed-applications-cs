using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieCatalogMVC.Models
{
    public class Rating
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "Rating")]
        [Required]
        [StringLength(5)]
        public string RatingValue { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}