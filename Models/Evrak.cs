using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Documents.Models
{
    public class Evrak
    {
        [Key]
        public Guid EvrakID { get; set; }
        public string Adi { get; set; }
        public string Konu { get; set; }
        public DateTime Tarih { get; set; }

        public string Url { get; set; }

        public int TipID { get; set; }
        public EvrakTipi EvrakTipi { get; set; }

        [NotMapped]
        public IFormFile Dosya { set; get; }

    }
}
