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
            _service = service; //injecao de independecia aplicada 
        }

        /// <summary>
        /// Adiciona pessoa no banco de dados
        /// </summary>
        /// <param name="P"></param>

            [HttpPost("adicionar-pessoa")]
        public void AdicionarPessoa(Pessoa P)
        {
            _service.AdicionarPessoa(P);
           
        }

        /// <summary>
        /// Lista todas as pessoas cadastradas na Farmácia do Banco de dados
        /// </summary>
        /// <returns></returns>

        [HttpGet("listar-Pessoa")]
        public List<Pessoa> ListarPessoa()
        {
           return _service.ListarPessoa();
        }


        /// <summary>
        ///Deleta uma pessoa do banco de dados por id
        /// </summary>
        /// <param name="id"></param>
        /// 
        [HttpDelete("Remover-pessoa")]
        public void RemoverPessoa(int id)
        {
            _service.RemoverPessoa(id); 
        }

        /// <summary>
        /// Edita pessoa do banco de dados por id
        /// </summary>
        /// <param name="P"></param>
        [HttpPut("Editar-Pessoa")]
        public void EditarPessoa(Pessoa P)
        {
            _service.EditarPessoa(P);
        }
    }
}
