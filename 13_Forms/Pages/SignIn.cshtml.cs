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
        public async void OnPost()
        {
            Forms? adm = FormsServices.Services.FormsServices.Get(0);
            adm.AdmOn = false;
            FormsServices.Services.FormsServices.Update(adm);

            if(FormsServices.Services.FormsServices.VerifyAccount(CheckUsr))
            {
                CheckUsr.On = 1;
                Response.Redirect("https://localhost:7237");
            }else if(FormsServices.Services.FormsServices.VerifyAdmin(CheckUsr))
            {   
                adm.AdmOn = true;
                FormsServices.Services.FormsServices.Update(adm);
                Response.Redirect("https://localhost:7237/AccountAdmin");
            }
        }
    }
}
