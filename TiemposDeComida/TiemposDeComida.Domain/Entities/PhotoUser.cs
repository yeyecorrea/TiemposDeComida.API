using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemposDeComida.Domain.Entities
{
    public class PhotoUser
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int ProfileUseId { get; set; }
        public ProfileUser ProfileUser { get; set; } = null!;
    }
}
