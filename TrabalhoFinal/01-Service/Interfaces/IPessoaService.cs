using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace TrabalhoFinal._01_Service.Interfaces
{
    public interface IPessoaService
    {
        void AdicionarPessoa(Pessoa P);
        void RemoverPessoa(int id);

        Pessoa FazerLogin(UsuarioLoginDTO usuarioLogin);
        List<Pessoa> ListarPessoa();
        Pessoa BuscarPorId(int id);
        void EditarPessoa(Pessoa P);
    }
}
