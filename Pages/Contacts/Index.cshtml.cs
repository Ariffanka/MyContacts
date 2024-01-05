using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactsApp.Data;
using ContactsApp.Models;

namespace ContactsApp.Contacts
{
    public class IndexModel : PageModel
    {
        private readonly ContactsApp.Data.ContactsAppContext _context;

        public IndexModel(ContactsApp.Data.ContactsAppContext context)
        {
            _context = context;
        }

        public IList<ContactsApp.Models.Contacts> Contacts { get; set; }

        public async Task OnGetAsync()
        {
            Contacts = await _context.Contacts.ToListAsync();
        }
    }
}
