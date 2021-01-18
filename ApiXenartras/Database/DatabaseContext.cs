using Microsoft.EntityFrameworkCore;
using PCC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ApiXenartras.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {   

        }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Aparicao> Aparicoes{ get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }
    }
}
