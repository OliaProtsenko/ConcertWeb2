using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ConcertWeb2.Models
{
    public class Concert
    {
        public Concert()
        {
            Tickets = new List<Ticket>();
            Perfomances = new List<Perfomance>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Квитків залишилось")]
        public int TicketsLeft { get; set; }

        [Display(Name = "Тип")]
        public string Type { get; set; }
        public int VenueId { get; set; }
        public virtual Venue Venue { get; set; }

        public virtual ICollection<Perfomance> Perfomances { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
