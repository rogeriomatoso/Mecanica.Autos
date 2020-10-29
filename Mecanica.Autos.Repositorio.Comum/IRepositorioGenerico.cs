using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica.Autos.Repositorios.Comum
{
    public interface IRepositorioGenerico<TEntidade, Tchave>
        where TEntidade : class
    {
        List<TEntidade> Selecionar();
        TEntidade SelecionarPorId(Tchave id);
        void Inserir(TEntidade enntidade);
        void Alterar(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void ExcluirPorId(Tchave id);

    }
}
