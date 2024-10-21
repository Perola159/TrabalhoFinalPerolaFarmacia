using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace API.Controllers;
[ApiController]
[Route("[controller]")]
public class CarrinhoController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly CarrinhoService _service;

    public CarrinhoController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new CarrinhoService(_config, mapper);
        _mapper = mapper;
    }


    [HttpPost("Adicionar-carrinho")]
    public void AdicionarProdutoCarrinho(Carrinho carrinho)
    {
        //Pessoa pessoa = _mapper.Map<Pessoa>(pessoaDTO);
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




