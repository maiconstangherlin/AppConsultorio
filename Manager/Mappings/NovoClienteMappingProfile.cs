using AutoMapper;
using Core.Domain;
using Core.Shared.ModelViews;
using System;

namespace Manager.Mappings
{
    public class NovoClienteMappingProfile : Profile
    {
        public NovoClienteMappingProfile()
        {
            CreateMap<NovoCliente, Cliente>()
                .ForMember(d => d.Criacao, o => o.MapFrom(x => DateTime.Now)) //Seta a data atual durante o mapping                                                                              
                .ForMember(d => d.DataNascimento, o => o.MapFrom(x => x.DataNascimento.Date)); //Remove a hora da data durante o mapping

            CreateMap<NovoEndereco, Endereco>();
        }
    }
}
