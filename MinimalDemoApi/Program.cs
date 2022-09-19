using MinimalDemoApi.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

//instantiating the repository in memory
var repository = new ProductRepository(true);

//endpoints
app.MapGet("/", () => "Welcome to Minimal Demo Api");

app.MapGet("/product/complete", () =>
{
    return repository.SelectAllProduct(); 
});

app.MapGet("/product/{code}", (string code) => 
{ 
    return repository.SelectProduct(code); 
});

app.MapPost("/product/add", (Product p) => 
{ 
    return repository.AddProduct(p); 
});

app.MapPut("/product/update", (Product p) => 
{
    return repository.UpdateProduct(p);
});

app.MapDelete("/product/remove", (string code) =>
{
    return repository.RemoveProduct(code);
});

app.Run();
