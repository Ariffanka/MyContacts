using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactsApp.Models;

namespace ContactsApp.Data
{
    public class ContactsAppContext : DbContext
    {
        public ContactsAppContext (DbContextOptions<ContactsAppContext> options)
            : base(options)
        {
        }

        public DbSet<ContactsApp.Models.Contacts> Contacts { get; set; }
    }
}
