using System.Text.Json;
using ContosoPizza.Models;
using System.IO;
namespace ContosoPizza.Services;

public static class PizzaService
{

    static List<Pizza>Pizzas {get;}
    static int nextId = 3;
    static PizzaService()
    {
        //Read a json file and parse it to create a list of pizzas.
        string fileName = "data.json";
        string jsonString = File.ReadAllText(fileName);
        Pizzas = JsonSerializer.Deserialize<List<Pizza>>(jsonString)!;
    }

    public static List<Pizza> GetAll() => Pizzas;
    
    public static Pizza? Get(int Id) => Pizzas.FirstOrDefault(p => p.Id == Id);

    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    public static void Delete(int id)
    {
        var pizza = Get(id);
        if(pizza is null)
            return;

        Pizzas.Remove(pizza);
    }

    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if(index == -1)
            return;

        Pizzas[index] = pizza;
    }

}