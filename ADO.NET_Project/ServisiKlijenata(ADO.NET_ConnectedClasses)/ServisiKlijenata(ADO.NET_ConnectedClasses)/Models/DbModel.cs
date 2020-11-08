using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_CRUD
{
    class DbModel : DbContext
    {
        public DbModel() : base("name=ServisAutomobila")
        {
        }

        public DbSet<Klijent> Klijenti { get; set; }

        public DbSet<Servis> Servisi { get; set; }
    }
}
