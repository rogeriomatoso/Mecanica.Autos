using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica.Autos.Generica.Entity
{
    public abstract class MecanicaEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public MecanicaEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
        }

        protected abstract void ConfigurarChavePrimaria();


        protected abstract void ConfigurarCamposTabela();


        protected abstract void ConfigurarNomeTabela();
        
    }
}
