using AutoMapper;
using TrabalhoFinal._03_Entidades.DTOS;
using TrabalhoFinal._03_Entidades;

namespace API
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CreateProdutoDTO, Produtos>().ReverseMap();
            CreateMap<ProdutoListagemDTO,Produtos>().ReverseMap();
        }
    }
}
