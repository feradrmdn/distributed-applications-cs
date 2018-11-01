using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Models
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
