using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Documents;
using System.ComponentModel;

namespace ADO.NET_CRUD
{
    [Table("Servisi", Schema = "dbo")]
    class Servis
    { 
        [Key][DisplayName("ID")]
        public int ServisId { get; set; }

        [Required(ErrorMessage = "Izaberite datum"), DisplayName("Datum")]
        public DateTime DatumServisa { get; set; }

        [Required(ErrorMessage = "Unesite opis usluge", AllowEmptyStrings = false), MaxLength(400), DisplayName("Usluga")]
        public string OpisUsluge { get; set; }

        [ForeignKey("Klijent")][DisplayName("KlijentFK")]
        public int KlijentId { get; set; }

        public Klijent Klijent { get; set; }
    }
}
