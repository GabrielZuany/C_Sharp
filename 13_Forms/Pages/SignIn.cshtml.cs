using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FormsModel.Models;

namespace SignIn.Pages
{
    public class SignInModel : PageModel
    {
         public List<Forms> Users = new();
        [BindProperty]
        public Forms CheckUsr {get; set;} = new();
        public void OnPost()
        {
            if(FormsServices.Services.FormsServices.VerifyAccount(CheckUsr))
            {
                Response.Redirect("https://localhost:7237");
            }else if(FormsServices.Services.FormsServices.VerifyAdmin(CheckUsr))
            {
                Response.Redirect("https://localhost:7237/AccountAdmin");
            }
        }
    }
}
