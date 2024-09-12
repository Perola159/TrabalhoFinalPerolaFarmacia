using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoControllers : ControllerBase
    {
        public readonly string _ConnectionString;
        private ProdutoService _service;
        public readonly IMapper _mapper;
        public ProdutoControllers(IConfiguration configuration,IMapper mapper)
        {
            _ConnectionString = configuration.GetConnectionString("DefaultConnection");
            _service = new ProdutoService(_ConnectionString);
            _mapper = mapper;
        }


        [HttpPost("adicionar-produto")]
        public void AdicionarProduto(CreateProdutoDTO P)
        {
            Produtos prod =_mapper.Map<Produtos>(P);
            _service.AdicionarProduto(prod);
        }

        [HttpGet("listar-Produto")]
        //public List<ProdutoListagemDTO> ListarProduto(ProdutoListagemDTO P)
        //{
        //    Produtos prod = _mapper.Map<Produtos>(P);
        //    List<ProdutoListagemDTO> list = _service.listarProduto();

        //    return list;
        //}

        [HttpDelete("Remover-produto")]
        public void RemoverProduto(int id)
        {
            _service.RemoverProduto(id); //controller chama a service passando --
                                        //parametro por id (que seria o id do time para executar a remoção)
        }

        [HttpPut("Editar-produto")]
        public void EditarProduto(Produtos P)
        {
            _service.EditarProduto(P);
        }
    }
}

