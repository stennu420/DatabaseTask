using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Muuseum 
    {
        [Key]

        public int Id { get; set; }
        public string Nimi { get; set; } = default!;
        public string Asukoht { get; set; } = default!;
        public string LahtiolekuAjad { get; set; } = default!;

        public ICollection<Naitus> Naitused { get; set; } = new List<Naitus>();
    }


}

