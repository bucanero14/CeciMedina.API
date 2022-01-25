using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CeciMedina.API.Models;
using CeciMedina.Core.Models;
using CeciMedina.Core.Models.Identity;
using CeciMedina.Core.Tools;
using Microsoft.AspNetCore.SignalR;

namespace CeciMedina.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Sucursal, SucursalModel>()
                .ReverseMap();

            CreateMap<Categoria, CategoriaModel>()
                .ReverseMap();

            CreateMap<ApplicationUser, UserModel>()
                .ReverseMap();

            CreateMap<DetallePedido, DetallePedidoModel>()
                .ForMember(dest => dest.ProductoId,
                    opt => opt.MapFrom(src => src.ProductoId))
                .ForMember(dest => dest.PedidoId,
                    opt => opt.MapFrom(src => src.PedidoId))
                .ReverseMap();
            
            CreateMap(typeof(PaginatedList<>), typeof(PaginatedList<>)).ConvertUsing(typeof(PaginatedListConverter<,>));
        }
    }
}