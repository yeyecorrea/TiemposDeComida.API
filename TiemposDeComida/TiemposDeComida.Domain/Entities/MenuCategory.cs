using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class MenuCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
    }
}
