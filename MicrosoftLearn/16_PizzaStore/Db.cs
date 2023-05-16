namespace PizzaStore.DB;

public record Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class PizzaDB
{
    private static List<Pizza> pizza_list = new List<Pizza>()
   {
     new Pizza{ Id=1, Name="Montemagno, Pizza shaped like a great mountain" },
     new Pizza{ Id=2, Name="The Galloway, Pizza shaped like a submarine, silent but deadly"},
     new Pizza{ Id=3, Name="The Noring, Pizza shaped like a Viking helmet, where's the mead"}
   };

    public static List<Pizza> GetPizzas()
    {
        return pizza_list;
    }

    public static Pizza? GetPizza(int id)
    {
        return pizza_list.SingleOrDefault(pizza => pizza.Id == id);
    }

    public static Pizza CreatePizza(Pizza pizza)
    {
        pizza_list.Add(pizza);
        return pizza;
    }

    public static Pizza UpdatePizza(Pizza pizza_to_be_updated)
    {
        pizza_list = pizza_list.Select(pizza =>
        {
            if (pizza.Id == pizza_to_be_updated.Id)
            {
                pizza.Name = pizza_to_be_updated.Name;
            }
            return pizza;
        }).ToList();
        return pizza_to_be_updated;
    }

    public static void RemovePizza(int id)
    {
        pizza_list = pizza_list.FindAll(pizza => pizza.Id != id).ToList();
    }
}