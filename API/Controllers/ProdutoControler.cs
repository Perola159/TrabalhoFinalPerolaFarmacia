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
        /// <summary>
        /// Adiciona um produto no banco de dados 
        /// </summary>
        /// <param name="P"></param>
        /// 
        [HttpPost("adicionar-produto")]
        public void AdicionarProduto(Produtos P)
        {
            _service.AdicionarProduto(P);
        }


        /// <summary>
        /// Lista os produtos que o usuário adicionou no banco
        /// </summary>
        /// <param name="P"></param>
        /// <returns></returns>
        [HttpGet("listar-Produto")]
        public List<ProdutoListagemDTO> ListarProduto(ProdutoListagemDTO P)
        {
            Produtos prod = _mapper.Map<Produtos>(P);
            List<ProdutoListagemDTO> list = _service.listarProduto();

            return list;
        }

        /// <summary>
        /// deleta os produtos adicionados pelo usuário
        /// </summary>
        /// <param name="id"></param>

        [HttpDelete("Remover-produto")]
        public void RemoverProduto(int id)
        {
            _service.RemoverProduto(id); 
        }

        /// <summary>
        /// Edita os produtos já adiconados no banco
        /// </summary>
        /// <param name="P"></param>
        [HttpPut("Editar-produto")]
        public void EditarProduto(Produtos P)
        {
            _service.EditarProduto(P);
        }
    }
}

