using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FormsModel.Models;

namespace AccountAdmin.Pages
{
    public class AccountAdminModel : PageModel
    {
        public List<Forms> Users = new();
        [BindProperty]
        public Forms NewUsr {get; set;} = new();

        public void OnGet()
        {   
            Users = FormsServices.Services.FormsServices.GetAll();
        }

        public IActionResult OnPostDelete(int id)
        {
            FormsServices.Services.FormsServices.Delete(id);
            return RedirectToAction("Get");
        }

        public IActionResult OnPost()
        {
            // do not reset the page after admin create a new user.
            var adm = FormsServices.Services.FormsServices.Get(0);
            adm.AdmOn = true;
            adm.On = 1;
            FormsServices.Services.FormsServices.Update(adm);

            if(!ModelState.IsValid){ // indicates if it was possible to bind the incoming values from the request to the model correctly and whether any explicitly specified validation rules were broken during the model binding process.
                return Page();
            }

            FormsServices.Services.FormsServices.Add(NewUsr);
            return RedirectToAction("Get");
        }
    }
}
