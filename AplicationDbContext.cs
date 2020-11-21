using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_arpilabeProject.Models;
using Microsoft.EntityFrameworkCore;

namespace back_arpilabeProject
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Contact> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=APContacts;Uid=root;Pwd=Marisa90");
        }

    }
}
