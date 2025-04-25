using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class ResponseOpinion
    {
        public int Id { get; set; }
        public int OpinionId { get; set; }
        public int RestaurantId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.UtcNow;

        public Opinion Opinion { get; set; } = null!;
        public Restaurant Restaurant { get; set; } = null!;
    }
}
