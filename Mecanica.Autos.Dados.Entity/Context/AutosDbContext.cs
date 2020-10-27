using Mecanica.Autos.Dados.Entity.TypeConfiguration;
using Mecanica.Autos.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica.Autos.Dados.Entity.Context
{
    public class AutosDbContext : DbContext
    {

        public DbSet<CarroPasseio> CarroPasseios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Configurations.Add(new CarroPasseioTypeConfiguration());
        }


    }
}
