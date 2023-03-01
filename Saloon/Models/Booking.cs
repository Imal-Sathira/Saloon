using System.ComponentModel.DataAnnotations;

namespace Saloon
{
    public class Booking
    {
        [Key]
        public string BookingID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public Customer Customer { get; set; }

        public Service Service { get; set; }
    }
}
