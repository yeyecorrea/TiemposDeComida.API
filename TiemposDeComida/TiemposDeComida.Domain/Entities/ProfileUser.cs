using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class ProfileUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Cities { get; set; }
        public string? Bio { get; set; }
        public string PhotoProfileUrl { get; set; } = null!;
        public DateTime DateRegistration { get; set; } = DateTime.UtcNow;

        // Relaciones
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<Opinion> Opinions { get; set; } = new List<Opinion>();
        public ICollection<PhotoUser> PhotoUsers { get; set; } = new List<PhotoUser>();
    }
}
