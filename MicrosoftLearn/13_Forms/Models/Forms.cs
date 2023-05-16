using System.ComponentModel.DataAnnotations;
namespace FormsModel.Models;

public class Forms
{   
    public int Id {get; set;}

    [Required, MaxLength(20), MinLength(2)]
    public string? Name {get; set;}
    [Required, MinLength(8), MaxLength(50)]
    public string? Password {get; set;}
    [Required, EmailAddress]
    public string? Mail{get; set;}
    public int On {get; set;}
    public bool AdmOn {get; set;}
}