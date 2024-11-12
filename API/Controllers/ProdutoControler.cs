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
        public IActionResult AdicionarProduto(Produtos P)
        {
            try
            {
                _service.AdicionarProduto(P);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro +" +
                    "o erro foi: " + erro.Message);
            }
            
        }


        /// <summary>
        /// Lista os produtos que o usuário adicionou no banco
        /// </summary>
        /// <param name="P"></param>
        /// <returns></returns>
        /// 

        [HttpGet("listar-Produto")]
        public List<Produtos> listarproduto()
        {

            try
            {
                return _service.listarProduto();
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro ao listar carrinho");
            }
        }

        /// <summary>
        /// deleta os produtos adicionados pelo usuário
        /// </summary>
        /// <param name="id"></param>

        [HttpDelete("Remover-produto")]
        public IActionResult RemoverProduto(int id)
        {
            try
            {
                _service.RemoverProduto(id);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro +" +
                    "o erro foi: " + erro.Message);
            }
            
        }

        /// <summary>
        /// Edita os produtos já adiconados no banco
        /// </summary>
        /// <param name="P"></param>
        [HttpPut("Editar-produto")]
        public IActionResult EditarProduto(Produtos P)
        {
            try
            {
                _service.EditarProduto(P);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro +" +
                    "o erro foi: " + erro.Message);
            }
           
        }
    }
}

