using FrontEnd;
using static System.Net.WebRequestMethods;

HttpClient cliente = new HttpClient
{
    BaseAddress = new Uri("https://localhost:7229/") 
};
Sistema sistema = new Sistema(cliente);
sistema.IniciarSistema();
