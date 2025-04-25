using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class EstablishmentType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
    }
}
