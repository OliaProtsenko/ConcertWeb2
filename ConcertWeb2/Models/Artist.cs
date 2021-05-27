using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ConcertWeb2.Models
{
    public class Artist
    {
        public Artist()
        {
            Perfomances = new List<Perfomance>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Артист")]
        public string Name { get; set; }

        public string Email { get; set; }
        public virtual ICollection<Perfomance> Perfomances { get; set; }
    }
}
