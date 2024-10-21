using FrontEnd;
HttpClient cliente = new HttpClient
{
    BaseAddress = new Uri("https://localhost:7096/")
};
Sistema sistema = new Sistema(cliente);
sistema.IniciarSistema();
