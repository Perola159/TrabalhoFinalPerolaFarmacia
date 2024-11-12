using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace API.Controllers;
[ApiController]
[Route("[controller]")]
public class CarrinhoController : ControllerBase
{
    private readonly ICarrinhoService _service;


    public CarrinhoController(ICarrinhoService service)
    {

        _service = service;

    }


    /// <summary>
    /// Adiciona os produtos do usuario logado no carrinho 
    /// </summary>
    /// <param name="carrinho"></param>
    /// 
    [HttpPost("Adicionar-carrinho")]
    public IActionResult AdicionarProdutoCarrinho(Carrinho carrinho)
    {
        try
        {
            _service.AdicionarProdutoCarrinho(carrinho);
            return Ok();
        }
        catch (Exception erro)
        {
            return BadRequest ("Ocorreu um erro +" +
                "o erro foi: " + erro.Message);
          
        }
    }


    /// <summary>
    /// Lista os produtos que o usuário selecionou no carrinho 
    /// </summary>
    /// <returns></returns>
    [HttpGet("Listar-carrinho")]
    public List<CarrinhoDTO> Listar()
    {
        try
        {
            return _service.ListarProdutoCarrinho();
        }
        catch (Exception)
        {
            throw new Exception("Ocorreu um erro ao listar carrinho");
        }
    }

    /// <summary>
    /// Edita os produtos selecionados pelo usuário do carrinho
    /// </summary>
    /// <param name="c"></param>
    /// 
    [HttpPut("editar-Carrinho")]
    public IActionResult EditarProdutoCarrinho(Carrinho c)
    {
        try
        {
            _service.EditarProdutoCarrinho(c);
            return Ok();
        }
        catch (Exception erro)
        {
            return BadRequest("Ocorreu um erro +" +
                "o erro foi: " + erro.Message);

        }
        
    }


    /// <summary>
    /// Delete o produto selecionado por ID
    /// </summary>
    /// <param name="c"></param>
    [HttpDelete("deletar-Produto-do-Carrinho")]
    public IActionResult DeletarProdutoCarrinho(Carrinho c)
    {
        try
        {
            _service.EditarProdutoCarrinho(c);
            return Ok();
        }
        catch (Exception erro)
        {
            return BadRequest("Ocorreu um erro +" +
                "o erro foi: " + erro.Message);

        }
      
    }
}




