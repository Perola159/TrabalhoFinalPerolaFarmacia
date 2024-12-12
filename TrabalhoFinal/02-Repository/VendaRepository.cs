using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;
using TrabalhoFinal._02_Repository.Interfaces;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

public class VendaRepository : IVendaRepository
{
    private readonly string _connectionString;
    private readonly string _vendaRepository;
    private readonly string _carrinhoService; 

    public VendaRepository(IConfiguration config)
    {
        _connectionString = config.GetConnectionString("DefaultConnection");
    }



    public List<VendaComCarrinhoDTO> ListarVenda()
    {
        // Corrigido: garantir que estamos pegando uma lista de objetos Venda
        var vendas = _vendaRepository.ListarVenda();

        // Convertendo para a DTO (VendaComCarrinhoDTO) 
        var vendasComCarrinho = vendas.Select(v => new VendaComCarrinhoDTO
        {
            IdVenda = v.Id,
            IdCarrinho = v.IdCarrinho,
            ItensCarrinho = _carrinhoService.ListarProdutoCarrinho() // Use o serviço do carrinho para obter os itens
        }).ToList();

        return vendasComCarrinho;
    }


    public Venda BuscarVendaPorId(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);
        return connection.Get<Venda>(id);
    }

    // Este método vai buscar o carrinho associado à venda
    public Carrinho BuscarCarrinhoPorId(int carrinhoId)
    {
        using var connection = new SQLiteConnection(_connectionString);
        return connection.Get<Carrinho>(carrinhoId);  // Assume que você tem a classe Carrinho e ela tem os itens
    }

    public void AdicionarVenda(Venda venda)
    {
        using var connection = new SQLiteConnection(_connectionString);
        connection.Insert<Venda>(venda);
    }


    public void EditarVenda(Venda venda)
    {
        using var connection = new SQLiteConnection(_connectionString);
        connection.Update<Venda>(venda);
    }



    public void RemoverVenda(int id)
    {
        using var connection = new SQLiteConnection(_connectionString);
        Venda removendovenda = BuscarVendaPorId(id);
        connection.Delete<Venda>(removendovenda);
    }
}
