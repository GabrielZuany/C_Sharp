using MyLinkedAPI.Models;
using MyLinkedAPIServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace MyLinkedAPI.Controllers;

[ApiController]
[Route("controller")]

public class MyLinkedAPIController : ControllerBase
{
    public MyLinkedAPIController()
    {      
    }
    
    // GET all action
    [HttpGet]
    public ActionResult<List<LinkedAPI>> GetAll() => MyLinkedAPIServices.Services.LinkedAPIService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<LinkedAPI> Get(int id)
    {   
        var api = MyLinkedAPIServices.Services.LinkedAPIService.Get(id);
        if(api == null)
        {
            return NotFound();
        }
        return api;
    }

    // POST action
    [HttpPost]    
    public IActionResult Create(LinkedAPI api)
    {
        MyLinkedAPIServices.Services.LinkedAPIService.Add(api);
        return CreatedAtAction(nameof(Create), api);
        //post -c "{"info1":"<inf>", "info2":false}"
    }

    //PUT action
    [HttpPut("{id}")]
    public IActionResult Add(LinkedAPI api)
    {
        MyLinkedAPIServices.Services.LinkedAPIService.Add(api);
        return NoContent();
    }

    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {   
        if(MyLinkedAPIServices.Services.LinkedAPIService.Get(id) == null)
        {
            return NotFound();
        }
        MyLinkedAPIServices.Services.LinkedAPIService.Delete(id);
        return NoContent();
    } 


}