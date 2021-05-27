using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ConcertWeb2.Models
{
    public class City
    {
        public City()
        {
            Venues = new List<Venue>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Місто")]
        public string Name { get; set; }
        public virtual ICollection<Venue> Venues { get; set; }

    }
}
