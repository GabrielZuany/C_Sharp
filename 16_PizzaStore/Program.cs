//If you've used earlier versions of .NET, you'll notice the lack of using statements.
//With .NET 6, the compiler figures out using statements for you.
//It's not something you need to care about.
using Microsoft.OpenApi.Models;
using PizzaStore.DB;

//Create a builder.
//From the builder, you construct an application instance app
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();


//Add swagger.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "PizzaStore", Description = "Making the pizzas you love",Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pizza Store API v1");
});


// Setting up the routes.
app.MapGet("/", () => "Hello World!");
app.MapGet("/pizzas/{id}", (int id) => PizzaDB.GetPizza(id));
app.MapGet("/pizzas", () => PizzaDB.GetPizzas());
app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));
app.MapPut("/pizzas", (Pizza pizza) => PizzaDB.UpdatePizza(pizza));
app.MapDelete("/pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));


//You can also use app instance to add middleware.
/*
Middleware is usually code that intercepts the request and carries out checks like checking for
authentication or ensuring the client is allowed to perform this operation according to CORS.
After the middleware is done executing, the actual request is carried out.
Data is either read or written to the store and a response is sent back to the calling client
*/
app.UseCors("some unique string");

app.Run();
