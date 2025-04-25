using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class PhotoRestaurant
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;
    }
}
