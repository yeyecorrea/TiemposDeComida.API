using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class Opinion
    {

        public int Id { get; set; }
        public int ApplicationUserId { get; set; }
        public int RestaurantId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Calification Calification { get; set; } // 1-5
        public string DateVisitMonth { get; set; } = null!; // Ej: "Abril"
        public string WhoDidYouGoWith { get; set; } = null!; // Amigos, pareja, solo

        public DateTime PublicationDate { get; set; } = DateTime.UtcNow;

        public ApplicationUser ApplicationUser { get; set; } = null!;
        public Restaurant Restaurant { get; set; } = null!;
        public ICollection<PhotoOpinion> PhotoOpinions { get; set; } = new List<PhotoOpinion>();
        public ResponseOpinion? ResponseOpinion { get; set; }
    }
}
