using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ConcertWeb2.Models
{
    public class Ticket
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Артист")]
        public int SeatNumber { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Ціна")]
        public int Price { get; set; }
        public int ConcertId { get; set; }
        public virtual Concert Concert { get; set; }
    }
}
