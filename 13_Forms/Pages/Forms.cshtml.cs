using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FormsModel.Models;

namespace FormsCSHTML.Pages
{
    public class FormsModel : PageModel
    {
        public List<Forms> Users = new();
        [BindProperty]
        public Forms NewUsr {get; set;} = new();

        public void OnGet()
        {   
            Users = FormsServices.Services.FormsServices.GetAll();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid){ // indicates if it was possible to bind the incoming values from the request to the model correctly and whether any explicitly specified validation rules were broken during the model binding process.
                return Page();
            }

            FormsServices.Services.FormsServices.Add(NewUsr);
            return RedirectToAction("Get");
        }
    }
}
