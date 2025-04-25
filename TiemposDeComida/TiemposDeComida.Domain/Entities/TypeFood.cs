using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class TypeFood
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<RestaurantTypeKitchen> RestaurantTypeKitchens { get; set; } = new List<RestaurantTypeKitchen>();
    }
}
