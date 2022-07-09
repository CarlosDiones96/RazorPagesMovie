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
        public string Title { get; set; }

        [Display(Name = "Data de estreia")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
       
        [Display(Name = "Gênero")]
        public string Genre { get; set; }

        [Display(Name = "Preço")]
        [Column (TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
