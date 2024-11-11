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
            using var connection = new SQLiteConnection("Data Source=PerolinhaFarmacêutica.db"); //criar conexão

            string criarTabela = @"   
                 CREATE TABLE IF NOT EXISTS Pessoas(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 EnderecoId INTEGER NOT NULL  ,
                 CPF REAL NOT NULL
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
                 IdProduto INT INTEGER PRIMARY KEY AUTOINCREMENT,
                 IdPessoa INTEGER NOT NULL                  
                );";

        }
    }
}
