using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica.Autos.Dominio
{
    public class CarroPasseio
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public int Ano { get; set; }
        public string RenavamUF { get; set; }
    }
}
