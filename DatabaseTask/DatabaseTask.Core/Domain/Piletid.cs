using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Base;

namespace DatabaseTask.Core.Domain
{
    public class Pilet : BaseEntity
    {
        public decimal Hind { get; set; }
        public DateTime Ostukuupaev { get; set; }
        public string KulastajaNimi { get; set; } = default!;

        public int NaitusId { get; set; }
        public Naitus Naitus { get; set; } = default!;
    }
}
