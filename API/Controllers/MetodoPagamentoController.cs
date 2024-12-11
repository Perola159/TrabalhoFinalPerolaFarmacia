using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._03_Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetodoPagamentoController : ControllerBase
    {
        private readonly IMetodoPagamentoService _service;

      
        public MetodoPagamentoController(IMetodoPagamentoService service)
        {
            _service = service;
        }

        /// <summary>
        /// Adiciona um novo método de pagamento
        /// </summary>
        /// <param name="metodoPagamento"></param>
        [HttpPost("Adicionar-metodo-pagamento")]
        public IActionResult AdicionarMetodoPagamento(MetodoPagamento metodoPagamento)
        {
            try
            {
                _service.AdicionarMetodoPagamento(metodoPagamento);
                return Ok("Método de pagamento adicionado com sucesso!");
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro: {erro.Message}");
            }
        }

        /// <summary>
        /// Lista todos os métodos de pagamento disponíveis
        /// </summary>
        [HttpGet("Listar-metodos-pagamento")]
        public IActionResult ListarMetodosPagamento()
        {
            try
            {
                var metodosPagamento = _service.ListarMetodosPagamento();
                return Ok(metodosPagamento);
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao listar métodos de pagamento: {erro.Message}");
            }
        }

        /// <summary>
        /// Edita um método de pagamento existente
        /// </summary>
        /// <param name="metodoPagamento"></param>
        [HttpPut("Editar-metodo-pagamento")]
        public IActionResult EditarMetodoPagamento([FromQuery] MetodoPagamento metodoPagamento)
        {
            try
            {
                _service.EditarMetodoPagamento(metodoPagamento);
                return Ok("Método de pagamento editado com sucesso!");
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao editar o método de pagamento: {erro.Message}");
            }
        }

        /// <summary>
        /// Deleta um método de pagamento
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("Deletar-metodo-pagamento/{id}")]
        public IActionResult DeletarMetodoPagamento(int id)
        {
            try
            {
                _service.RemoverMetodoPagamento(id);
                return Ok("Método de pagamento removido com sucesso!");
            }
            catch (Exception erro)
            {
                return BadRequest($"Ocorreu um erro ao remover o método de pagamento: {erro.Message}");
            }
        }
    }
}
