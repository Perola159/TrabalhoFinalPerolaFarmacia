using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        public readonly  IPessoaService _service;

        public PessoaController(IPessoaService service)
        {
            _service = service; //injecao de dependecia aplicada 
        }

        /// <summary>
        /// Adiciona pessoa no banco de dados
        /// </summary>
        /// <param name="P"></param>
        [HttpPost("adicionar-pessoa")]
        public IActionResult AdicionarPessoa(Pessoa P)
        {
          


            try
            {
                // Chama o serviço para adicionar a pessoa, passando a pessoa com CPF validado
                _service.AdicionarPessoa(P);
                return Ok(); // Retorna OK se deu certo
            }
            catch (Exception erro)
            {
                // Caso ocorra algum erro, retorna uma resposta de erro com a mensagem
                return BadRequest("Ocorreu um erro: " + erro.Message);
            }
        }



        /// <summary>
        /// Lista todas as pessoas cadastradas na Farmácia do Banco de dados
        /// </summary>
        /// <returns></returns>

        [HttpGet("listar-Pessoa")]
        public List<Pessoa> ListarPessoa()
        {
            try
            {
                return _service.ListarPessoa();
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro ao listar carrinho");
            }
            
        }


        /// <summary>
        ///Deleta uma pessoa do banco de dados por id
        /// </summary>
        /// <param name="id"></param>
        /// 
        [HttpDelete("Remover-pessoa")]
        public IActionResult RemoverPessoa(int id)
        {
            try
            {
                _service.RemoverPessoa(id);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro +" +
                    "o erro foi: " + erro.Message);
            }
         
        }

        /// <summary>
        /// Edita pessoa do banco de dados por id
        /// </summary>
        /// <param name="P"></param>
        [HttpPut("Editar-Pessoa")]
        public IActionResult EditarPessoa(Pessoa P)
        {
            try
            {
                _service.EditarPessoa(P);
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
