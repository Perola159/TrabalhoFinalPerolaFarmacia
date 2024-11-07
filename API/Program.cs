using API;
using TrabalhoFinal._01_Service.Interfaces;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._02_Repository.DATA;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapProfile));
InicializadorBd.Inicializar();

builder.Services.AddScoped<ICarrinhoService, CarrinhoService>();
builder.Services.AddScoped<IEnderecoService, EnderecoService>();
builder.Services.AddScoped<IPessoaService, PessoaService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
