using Mecanica.Autos.Web.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mecanica.Autos.Web.ViewModels.CarroPasseio
{
    public class CarroPasseioViewModel
    {
        [Required (ErrorMessage ="O Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O modelo do carro é obrigatório")]
        [MaxLength(100, ErrorMessage ="O modelo pode ter no maximo 100 caracteres")]
        [Display(Name = "Modelo do Carro")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória")]
        [MaxLength(100, ErrorMessage = "A marca do carro pode ter no maximo 100 caracteres")]
        [Display(Name = "Marca do Carro")]
        public string Marca { get; set; }

        
        [MaxLength(50, ErrorMessage = "O modelo pode ter no maximo 50 caracteres")]
        [Display(Name = "Cor do Carro")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "O combustível do carro é obrigatório")]
        [MaxLength(20, ErrorMessage = "O combustível pode ter no maximo 20 caracteres")]
        [Display(Name = "Combustível")]
        public string Combustivel { get; set; }

        [Required(ErrorMessage = "O ano do carro é obrigatório")]        
        [Display(Name = "Ano do Carro")]
        public int Ano { get; set; }

        [Display(Name = "Renavam - UF")]
        [Required(ErrorMessage ="Campo obrigatorio")]
        //[MaxLength(14, ErrorMessage ="Campo deve conter l4 caracteres")]
        //[MinLength(14, ErrorMessage = "Campo deve conter l4 caracteres")]
       //[RenavamUF(ErrorMessage ="Inscrição Renavam deve conter sufixo -MG")]
       [Renavam(ErrorMessage ="Campo deve conter 11 caracteres")]
        public string RenavamUF { get; set; }

        
    }
}