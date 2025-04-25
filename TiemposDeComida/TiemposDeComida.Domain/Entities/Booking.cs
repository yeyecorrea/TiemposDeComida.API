using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int ApplicationUserId { get; set; }

        public int NumberOfPeople { get; set; }
        public DateTime TimeDate { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? SpecialRequests { get; set; }

        public BookingStatus bookingStatus { get; set; } = BookingStatus.Pending;

        public ApplicationUser ApplicationUser { get; set; } = null!;
        public Restaurant Restaurant { get; set; } = null!;
    }
}
