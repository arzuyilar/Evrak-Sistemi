using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Documents.Models
{
    public class EvrakTipi
    {
        [Key]
        public int TipID { get; set; }
        public string TipAdi { get; set; }

        public IList<Evrak> Evraks { get; set; }
    }
}
