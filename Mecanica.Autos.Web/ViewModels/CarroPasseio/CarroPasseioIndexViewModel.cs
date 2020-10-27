using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mecanica.Autos.Web.ViewModels.CarroPasseio
{
    public class CarroPasseioIndexViewModel
    {
        
        public int Id { get; set; }


        [Display(Name = "Modelo do Carro")]
        public string Modelo { get; set; }


        [Display(Name = "Marca do Carro")]
        public string Marca { get; set; }


        [Display(Name = "Cor do Carro")]
        public string Cor { get; set; }


        [Display(Name = "Combustível")]
        public string Combustivel { get; set; }


        [Display(Name = "Ano do Carro")]
        public int Ano { get; set; }

        [Display(Name ="Renavam - UF")]
        public string RenavamUF { get; set; }
    }
}