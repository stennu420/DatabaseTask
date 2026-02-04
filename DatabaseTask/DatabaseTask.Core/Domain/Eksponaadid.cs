using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Base;

namespace DatabaseTask.Core.Domain
{
    public class Eksponaat : BaseEntity
    {
        public string Nimetus { get; set; } = default!;
        public string Paritolumaa { get; set; } = default!;
        public string Ajastu { get; set; } = default!;
        public string Materjal { get; set; } = default!;
        public decimal HinnangulineVaartus { get; set; }

        public int AnnetajaId { get; set; }
        public Annetaja Annetaja { get; set; } = default!;

        public int NaitusId { get; set; }
        public Naitus Naitus { get; set; } = default!;
    }
}
