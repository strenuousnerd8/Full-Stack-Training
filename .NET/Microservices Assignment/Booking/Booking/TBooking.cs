using System.ComponentModel.DataAnnotations;

namespace Booking
{
    public class TBooking
    {
        [Key]
        public String? BookingId { get; set; }

        public String? Name { get; set; }

        public String? BookingDescription { get; set; }

        public DateTime BookingDate { get; set; }
    }
}
