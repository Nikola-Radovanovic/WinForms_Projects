using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_CRUD
{
    [Table("Klijenti", Schema = "dbo")]
    class Klijent
    {
        public Klijent()
        {
            Servisi = new List<Servis>();
        }

        [Key]
        [DisplayName("ID")]
        [Column("KlijentId")]
        public int KlijentId { get; set; }

        [Required(ErrorMessage = "Unesite naziv klijenta", AllowEmptyStrings = false), MaxLength(40), DisplayName("Klijent")]
        [Column("NazivKlijenta")]
        public string NazivKlijenta { get; set; }

        [Required(ErrorMessage = "Unesite registraciju vozila", AllowEmptyStrings = false), MaxLength(20), DisplayName("Registracija")]
        public string RegistarskiBroj { get; set; }

        [Required(ErrorMessage = "Unesite adresu klijenta", AllowEmptyStrings = false), MaxLength(40), DisplayName("Kontakt")]
        public string Kontakt { get; set; }

        [MaxLength(200), DisplayName("Komentar")]
        public string DodatniKomentar { get; set; }

        public ICollection<Servis> Servisi { get; set; }
    }
}
