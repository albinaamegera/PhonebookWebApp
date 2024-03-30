using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhonebookWebApp.Models;

namespace PhonebookWebApp.Data
{
    public class PhonebookWebAppContext : DbContext
    {
        public PhonebookWebAppContext (DbContextOptions<PhonebookWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<PhonebookWebApp.Models.Note> Note { get; set; } = default!;
    }
}
