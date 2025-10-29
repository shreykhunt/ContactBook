using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactBook.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}