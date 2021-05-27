using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ConcertWeb2.Models
{
    public class Perfomance
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Жанр")]
        public string Genre { get; set; }
        public int ArtistId { get; set; }
        public int ConcertId { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Concert Concert { get; set; }
    }
}
