using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper; //importando
using Projeto.Presentation.Models; //importando
using Projeto.Entities; //importando

namespace Projeto.Presentation.Mappings
{
    //REGRA: Herdar a classe Profile do AutoMapper
    public class ViewModelToEntityMap : Profile
    {
        //construtor -> ctor + 2x[tab]
        public ViewModelToEntityMap()
        {
            CreateMap<ContaCadastroViewModel, Conta>();
        }
    }
}