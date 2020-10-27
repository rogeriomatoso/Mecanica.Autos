using AutoMapper;
using Mecanica.Autos.Dominio;
using Mecanica.Autos.Web.ViewModels.CarroPasseio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mecanica.Autos.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<CarroPasseio, CarroPasseioIndexViewModel>()
                .ForMember(r => r.Modelo, opt =>
                 {
                     opt.MapFrom(src =>
                     string.Format("{0} ({1})", src.Modelo, src.Ano.ToString())

                         );
                 });

            Mapper.CreateMap<CarroPasseio, CarroPasseioViewModel>();
        }
    }
}