using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal._02_Repository.DATA
{
    public static class InicializadorBd
    {


        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=PerolinhaFarmacêutica.db"); // criar conexão

            string criarTabela = @"   
        CREATE TABLE IF NOT EXISTS Pessoas(
        ID INTEGER PRIMARY KEY AUTOINCREMENT,
        Nome TEXT NOT NULL,
        CPF TEXT NOT NULL ,
        Telefone INT NOT NULL
        );";


            criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS Produtos(
                 Nome TEXT NOT NULL,
                 Preco  NOT NULL,
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 QuantidadeEstoque  NOT NULL
                );";

            criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS Enderecos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Rua TEXT NOT NULL,
                 Bairro TEXT NOT NULL,
                 Numero INTEGER NOT NULL                  
                );";

            criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS Carrinhos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 IdProduto INTEGER NOT NULL,
                 IdPessoa INTEGER NOT NULL                  
                );";

            criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS Vendas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 IdCarrinho INTEGER NOT NULL   
                );";


            criarTabela += @"   
                 CREATE TABLE IF NOT EXISTS MetodoPagamentos(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Tipo TEXT NOT NULL,
                 Ativo BOOLEAN NOT NULL,
                 TaxaTransacao DECIMAL(5, 2)
                 );";



            connection.Execute(criarTabela);
        }
    }
}

