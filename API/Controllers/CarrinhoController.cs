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
    

    public CarrinhoController( ICarrinhoService service)
    {
   
        _service=service;

    }


    /// <summary>
    /// Adiciona os produtos do usuario logado no carrinho 
    /// </summary>
    /// <param name="carrinho"></param>
    /// 
        [HttpPost("Adicionar-carrinho")]
    public void AdicionarProdutoCarrinho(Carrinho carrinho)
    {
        
        _service.AdicionarProdutoCarrinho(carrinho);
    }


    /// <summary>
    /// Lista os produtos que o usuário selecionou no carrinho 
    /// </summary>
    /// <returns></returns>
    [HttpGet("Listar-carrinho")]
    public List<CarrinhoDTO> Listar()
    {
        return _service.ListarProdutoCarrinho();
    }

    /// <summary>
    /// Edita os produtos selecionados pelo usuário do carrinho
    /// </summary>
    /// <param name="c"></param>
    [HttpPut("editar-Carrinho")]
    public void EditarProdutoCarrinho(Carrinho c)
    {
        _service.EditarProdutoCarrinho(c);
    }

    /// <summary>
    /// Delete o produto selecionado por ID
    /// </summary>
    /// <param name="c"></param>
    [HttpDelete("deletar-Produto-do-Carrinho")]
    public void DeletarProdutoCarrinho(Carrinho c)
    {
        _service.EditarProdutoCarrinho(c);
    }
}




