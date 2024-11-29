using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._03_Entidades;
using System;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendaController : ControllerBase  
    {
        private readonly IVendaService _service;

        public VendaController(IVendaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Adiciona uma venda no banco de dados
        /// </summary>
        /// <param name="venda"></param>
        [HttpPost("adicionar-venda")]
        public IActionResult AdicionarVenda([FromBody] Venda venda)  
        {
            try
            {
                _service.AdicionarVenda(venda);
                return Ok("Venda adicionada com sucesso");
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro: " + erro.Message);
            }
        }

        /// <summary>
        /// Lista todas as vendas cadastradas
        /// </summary>
        /// <returns>Lista de Vendas</returns>
        [HttpGet("listar-vendas")]
        public IActionResult ListarVendas()
        {
            try
            {
                var vendas = _service.listarVenda();
                return Ok(vendas);
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro ao listar as vendas: " + erro.Message);
            }
        }

        /// <summary>
        /// Deleta uma venda pelo ID
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("remover-venda/{id}")]
        public IActionResult RemoverVenda(int id)
        {
            try
            {
                _service.RemoverVenda(id);
                return Ok("Venda removida com sucesso");
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro: " + erro.Message);
            }
        }

        /// <summary>
        /// Edita uma venda existente
        /// </summary>
        /// <param name="venda"></param>
        [HttpPut("editar-venda")]
        public IActionResult EditarVenda([FromBody] Venda venda)
        {
            try
            {
                _service.EditarVenda(venda);
                return Ok("Venda editada com sucesso");
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro: " + erro.Message);
            }
        }

        /// <summary>
        /// Busca uma venda pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Venda</returns>
        [HttpGet("buscar-venda/{id}")]
        public IActionResult BuscarVendaPorId(int id)
        {
            try
            {
                var venda = _service.BuscarVendaPorId(id);
                if (venda == null)
                {
                    return NotFound("Venda não encontrada");
                }
                return Ok(venda);
            }
            catch (Exception erro)
            {
                return BadRequest("Ocorreu um erro: " + erro.Message);
            }
        }
    }
}
