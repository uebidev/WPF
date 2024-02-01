using BeautifulCrud.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulCrud.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Member> Member { get; set; }

        //essa é a parte mais importante, a parte da configuração
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "server=127.0.0.1;port=3306;database=club;uid=root;password=root"; //aqui vai a string de conexão mano
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)); //esse metodo tem duas sobrecargas, caso tu queira se aprofundar
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasKey(m => m.Id);
        }
    }
}
