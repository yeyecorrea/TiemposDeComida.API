using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;

        public Restaurant Restaurant { get; set; } = null!;
        public int MenuCategoryId { get; set; }
        public MenuCategory MenuCategory { get; set; } = null!;
    }
}
