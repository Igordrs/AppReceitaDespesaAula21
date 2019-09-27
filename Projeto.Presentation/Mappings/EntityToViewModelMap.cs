using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper; //importando
using Projeto.Presentation.Models; //importando
using Projeto.Entities; //importando
using Projeto.TransferObjects; //importando

namespace Projeto.Presentation.Mappings
{
    public class EntityToViewModelMap : Profile
    {
        //construtor -> ctor + 2x[tab]
        public EntityToViewModelMap()
        {
            CreateMap<SomatorioContaDTO, PieChartViewModel>()
                .AfterMap((src, dest) => dest.name = src.Categoria)
                .AfterMap((src, dest) => dest.data = src.Somatorio);
        }
    }
}