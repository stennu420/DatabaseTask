using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{

    public class Naitus
    {
        [Key]
        public string Nimi { get; set; } = default!;
        public DateTime Alguskuupaev { get; set; }
        public DateTime Loppkuupaev { get; set; }
        public string Asukoht { get; set; } = default!;
        public string Saal { get; set; } = default!;

        public int MuuseumId { get; set; }
        public Muuseum Muuseum { get; set; } = default!;

        // vastutav töötaja/kuraator (soovitan lisada, et vastaks ülesande tekstile)
        public int TootajaId { get; set; }
        public Tootaja Tootaja { get; set; } = default!;

        public ICollection<Eksponaat> Eksponaadid { get; set; } = new List<Eksponaat>();
        public ICollection<Pilet> Piletid { get; set; } = new List<Pilet>();
    }
}
