using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class RestaurantTypeKitchen
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; } = null!;
        public int TypeKitchenId { get; set; }
        public TypeKitchen TypeKitchen { get; set; } = null!;
    }
}
