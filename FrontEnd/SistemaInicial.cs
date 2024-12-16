using FrontEnd.Models;
using FrontEnd.Models.UseCases;
using TrabalhoFinal._03_Entidades;
using TrabalhoFinal._03_Entidades.DTOS;

namespace FrontEnd
{
    public class Sistema
        {
            private static Pessoa UsuarioLogado { get; set; }
            private readonly PessoaUC _usuarioUC;
            private readonly ProdutoUC _produtoUC;
            private readonly CarrinhoUC _carrinhoUC;
            public Sistema(HttpClient cliente)
            {
                _usuarioUC = new PessoaUC(cliente);
                _produtoUC = new ProdutoUC(cliente);
                _carrinhoUC = new CarrinhoUC(cliente);
            }
            public void IniciarSistema()
            {
                int resposta = -1;
                while (resposta != 0)
                {
                    if (UsuarioLogado == null)
                    {
                        resposta = ExibirLogin();

                        if (resposta == 1)
                        {
                            FazerLogin();
                        }
                        else if (resposta == 2)
                        {
                            Pessoa usuario = CriarUsuario();
                            _usuarioUC.CadastrarUsuario(usuario);
                            Console.WriteLine("Usuário cadastrado com sucesso");
                        }
                        else if (resposta == 3)
                        {
                            List<Pessoa> usuarios = _usuarioUC.ListarUsuarios();
                            foreach (Pessoa u in usuarios)
                            {
                                Console.WriteLine(u.ToString());
                            }
                        }
                    }
                    else
                    {
                        ExibirMenuPrincipal();
                    }
                }
            }
            public int ExibirLogin()
            {
                Console.WriteLine("========== LOGIN ==========");
                Console.WriteLine("1 - Deseja Fazer Login");
                Console.WriteLine("2 - Deseja se Cadastrar");
                Console.WriteLine("3 - Listar Usuario Cadastrados");
                return int.Parse(Console.ReadLine());
            }

            public Pessoa CriarUsuario()
            {
                Pessoa usuario = new Pessoa();
                Console.WriteLine("Digite seu nome: ");
                usuario.Nome = Console.ReadLine();
                Console.WriteLine("Digite seu username: ");
                usuario.Username = Console.ReadLine();
                Console.WriteLine("Digite seu senha: ");
                usuario.Senha = Console.ReadLine();
                Console.WriteLine("Digite seu email: ");
                usuario.Email = Console.ReadLine();
                return usuario;
            }

        public void FazerLogin()
        {
            Console.WriteLine("Digite seu username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();
            UsuarioLoginDTO usuDTO = new UsuarioLoginDTO
            {
                Username = username,
                Senha = senha
            };
            Pessoa usuario = _usuarioUC.FazerLogin(usuDTO);
            if (usuario == null)
            {
                Console.WriteLine("Usuário ou senha inválidos!!!");
            }
            UsuarioLogado = usuario;
        }

        public Produto CriarProduto()
            {
                Produto usuario = new Produto();
                Console.WriteLine("Digite o nome do produto: ");
                usuario.Nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto: ");
                usuario.Preco = double.Parse(Console.ReadLine());
                return usuario;
            }
            
            public void ExibirMenuPrincipal()
            {
            Console.WriteLine("==========ESCOLHA UMA DAS OPÇÕES ABAIXO==========");
                Console.WriteLine("Qual operação deseja realizar?");
                Console.WriteLine("1 - Listar Produtos");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Realizar uma compra");
              
                int resposta = int.Parse(Console.ReadLine());

                if (resposta == 1)
                {
                    ListarProdutos();
                }
                else if (resposta == 2)
                {
                    Produto produto = CriarProduto();
                    _produtoUC.CadastrarProduto(produto);
                    Console.WriteLine("Produto cadastrado com sucesso");
                }
                else if (resposta == 3)
                {
                    int opcao = 1;
                    while (opcao == 1)
                    {
                        //Listar Produto
                        ListarProdutos();
                        //Escolher Produto
                        Console.WriteLine("Digite os produtos que deseja comprar:");
                        int produtoId = int.Parse(Console.ReadLine());
                        Carrinho c = new Carrinho();
                        c.ProdutoId = produtoId;
                        c.UsuarioId = UsuarioLogado.Id;
                        _carrinhoUC.CadastrarCarrinho(c);

                        Console.WriteLine("Escolha a opção: " +
                            "\n 1- Escolher mais produtos" +
                            "\n 2- Finalizar compra");
                        opcao = int.Parse(Console.ReadLine());
                    }
                    List<ReadCarrinhoDTO> carrinhosDTO = _carrinhoUC.ListarCarrinhoUsuarioLogado();
                    foreach (ReadCarrinhoDTO car in carrinhosDTO)
                    {
                        Console.WriteLine(car.ToString());
                    }
                }
            }


        public void FinalizarCompra()
        {
            
            List<ReadCarrinhoDTO> carrinhosDTO = _carrinhoUC.ListarCarrinhoUsuarioLogado();
            decimal totalCompra = carrinhosDTO.Sum(c => c.PrecoTotal);

            Console.WriteLine($"O total da compra é: R$ {totalCompra:F2}");
            Console.WriteLine("Escolha o método de pagamento:");
            Console.WriteLine("1 - Dinheiro\n2 - Cartão\n3 - PIX");
            int metodo = int.Parse(Console.ReadLine());

            if (metodo == 1)
            {
                Console.WriteLine("Informe o valor pago em dinheiro:");
                decimal valorPago = decimal.Parse(Console.ReadLine());
                if (valorPago >= totalCompra)
                {
                    decimal troco = valorPago - totalCompra;
                    Console.WriteLine($"Pagamento realizado! Troco: R$ {troco:F2}");
                }
                else
                {
                    Console.WriteLine("Valor insuficiente para a compra.");
                    return;
                }
            }
            else if (metodo == 2)
            {
                Console.WriteLine("Pagamento realizado no cartão!");
            }
            else if (metodo == 3)
            {
                Console.WriteLine("Insira o código do PIX:");
                string pixCode = Console.ReadLine();
                Console.WriteLine($"Pagamento via PIX ({pixCode}) realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Método de pagamento inválido.");
                return;
            }
        }
        private void ListarProdutos()
            {
                List<Produto> produtos = _produtoUC.ListarProduto();
                foreach (Produto u in produtos)
                {
                    Console.WriteLine(u.ToString());
                }
            }
        }


}

