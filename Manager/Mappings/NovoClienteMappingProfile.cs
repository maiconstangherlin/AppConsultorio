using AutoMapper;
using Core.Domain;
using Core.Shared.ModelViews;

namespace Manager.Mappings
{
    public class NovoClienteMappingProfile : Profile
    {
        public NovoClienteMappingProfile()
        {
            CreateMap<NovoCliente, Cliente>();
        }
    }
}
