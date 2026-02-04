using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Base;

namespace DatabaseTask.Core.Domain
{
    public class Annetaja : BaseEntity
    {
        public string Nimi { get; set; } = default!;
        public string Aadress { get; set; } = default!;
        public string Kontaktinfo { get; set; } = default!;

        public ICollection<Eksponaat> Eksponaadid { get; set; } = new List<Eksponaat>();
    }
}
