using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades.DTOS;


namespace TrabalhoFinal._02_Repository.Interfaces
{
    public interface IEnderecoRepository
    {
        void AdicionarContrib(Endereco P);
        List<Endereco> ListarEndereco();
        Endereco BuscarEndereco(int id);
        void EditarEndereco(Endereco P);
        void DeleteEndereco(int id);
    }
}
