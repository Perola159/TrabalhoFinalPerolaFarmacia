using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        public readonly IProdutoService _service;
        
  
        public ProdutoController(IProdutoService serv)
        {
            _service = serv;
        }

        [HttpPost("adicionar-produto")]
        public void AdicionarProduto(Produtos P)
        {
            _service.AdicionarProduto(P);
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
            _service.RemoverProduto(id); 
        }

        [HttpPut("Editar-produto")]
        public void EditarProduto(Produtos P)
        {
            _service.EditarProduto(P);
        }
    }
}

