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
    }
}
