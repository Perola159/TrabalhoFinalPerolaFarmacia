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

        [HttpPost("Adicionar-carrinho")]
    public void AdicionarProdutoCarrinho(Carrinho carrinho)
    {
        
        _service.AdicionarProdutoCarrinho(carrinho);
    }

    [HttpGet("Listar-carrinho")]
    public List<CarrinhoDTO> Listar()
    {
        return _service.ListarProdutoCarrinho();
    }
    [HttpPut("editar-Carrinho")]


    public void EditarProdutoCarrinho(Carrinho c)
    {
        _service.EditarProdutoCarrinho(c);
    }

    [HttpDelete("deletar-Produto-do-Carrinho")]
    public void DeletarProdutoCarrinho(Carrinho c)
    {
        _service.EditarProdutoCarrinho(c);
    }
}




