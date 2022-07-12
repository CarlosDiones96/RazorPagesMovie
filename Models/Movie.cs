using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
       
        [Display(Name = "Título")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Data de estreia")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
       
        [Display(Name = "Gênero")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string Genre { get; set; }

        [Display(Name = "Preço")]
        [Column (TypeName = "decimal(18, 2)")]
        [Range(1, 200)]
        public decimal Price { get; set; }

        [Display(Name = "Classificação")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(10)]
        [Required]
        public string Rating { get; set; }
    }
}
