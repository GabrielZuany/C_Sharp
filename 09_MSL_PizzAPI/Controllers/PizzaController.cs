using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => 
        PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);

        if(pizza == null){
            return NotFound();
        }
        return pizza;
    }

    // POST action
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza);
        return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
        //post -c "{"name":"<name>", "IsGlutenFree":false}"
    }

    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(Pizza pizza)
    {   
        PizzaService.Update(pizza);
        return NoContent();
        //put <id> -c  "{"id": id, "name":"<new name>", "isGlutenFree":<new bool>}"
    }

    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {   
        if(PizzaService.Get(id) == null)
        {
            return NotFound();
        }
        PizzaService.Delete(id);
        return NoContent();
    }

}