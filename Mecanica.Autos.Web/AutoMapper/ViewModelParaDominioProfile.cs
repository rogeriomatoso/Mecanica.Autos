using AutoMapper;
using Mecanica.Autos.Dominio;
using Mecanica.Autos.Web.ViewModels.CarroPasseio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mecanica.Autos.Web.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<CarroPasseioViewModel, CarroPasseio>();
        }
    }
}