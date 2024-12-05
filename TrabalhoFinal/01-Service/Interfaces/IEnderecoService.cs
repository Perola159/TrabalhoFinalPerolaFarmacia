using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface IEnderecoService
    {
        void AdicionarEndereco(Endereco P);
        void RemoverEndereco(int id);
        List<Endereco> ListarEndereco();
        public List<Endereco> ListarEnderecoPorId(int id);
        Endereco BuscarPorId(int id);
        void EditarEndereco(Endereco P);
    }
}
