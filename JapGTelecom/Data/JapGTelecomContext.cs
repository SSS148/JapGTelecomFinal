using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JapGTelecom.Models;

namespace JapGTelecom.Data
{
    public class JapGTelecomContext : DbContext
    {
        public JapGTelecomContext (DbContextOptions<JapGTelecomContext> options)
            : base(options)
        {
        }

        public DbSet<JapGTelecom.Models.Login> Login { get; set; }

        public DbSet<JapGTelecom.Models.Mobile> Mobile { get; set; }

        public DbSet<JapGTelecom.Models.feedBack> feedBack { get; set; }

        public DbSet<JapGTelecom.Models.Offer> Offer { get; set; }

        public DbSet<JapGTelecom.Models.Stock> Stock { get; set; }
    }
}
