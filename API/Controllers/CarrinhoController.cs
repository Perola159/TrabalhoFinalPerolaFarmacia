using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._05_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoController : ControllerBase
    {
        private readonly ICarrinhoService _service;

        public CarrinhoController(ICarrinhoService service)
        {
            _service = service;
        }

        // Adiciona produto ao carrinho
        [HttpPost("AdicionarProdutoCarrinho")]
        public IActionResult AdicionarProdutoCarrinho([FromBody] Carrinho carrinho)
        {
            try
            {
                _service.AdicionarProdutoCarrinho(carrinho);
                return Ok("Produto adicionado ao carrinho.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        // Lista os carrinhos
        [HttpGet("ListarCarrinhos")]
        public IActionResult ListarCarrinhos()
        {
            var carrinhos = _service.ListarProdutoCarrinho();
            return Ok(carrinhos);
        }

        // Deleta carrinho
        [HttpDelete("DeletarCarrinho/{id}")]
        public IActionResult DeletarCarrinho(int id)
        {
            try
            {
                _service.DeletarProdutoCarrinho(id);
                return Ok("Carrinho deletado.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}
