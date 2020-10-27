using Mecanica.Autos.Dominio;
using Mecanica.Autos.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica.Autos.Dados.Entity.TypeConfiguration
{
    class CarroPasseioTypeConfiguration : MecanicaEntityAbstractConfig<CarroPasseio>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Modelo)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Modelo");

            Property(p => p.Marca)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Marca");

            Property(p => p.Cor)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnName("Cor");

            Property(p => p.Combustivel)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("Combustivel");

            Property(p => p.Ano)
                .IsOptional()                
                .HasColumnName("Ano");

            Property(r => r.RenavamUF)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("Renavam - UF");
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("CarroPasseio");
        }
    }
}
