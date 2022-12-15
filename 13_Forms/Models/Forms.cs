using System.ComponentModel.DataAnnotations;

namespace FormsModel.Models;

public class Forms
{   
    public int Id {get; set;}

    [Required, MaxLength(20), MinLength(2)]
    public string? Name {get; set;}
    [Required, MinLength(8)]
    public string? Password {get; set;}
    [Required]
    public string? Mail{get; set;}
}