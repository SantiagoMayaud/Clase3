using System.ComponentModel.DataAnnotations;

namespace Clase3.Models;

public class Movie{
    [Display(Name="Código ID")]
    [Required]
    public string Code {get; set;}
    
    [Display(Name="Nombre")] //Esto le cambia el nombre a la propiedad "Name" por "Nombre"
    [Required]
    public string Name {get; set;}

        [Display(Name="Minutos")] //Esto le cambia el nombre a la propiedad "Name" por "Nombre"
    [Required]
    [Range(5,600)]
    public int Minutes {get; set;}

        [Display(Name="Categoria")] //Esto le cambia el nombre a la propiedad "Name" por "Nombre"
    [Required]
    public string Category {get; set;}

    [Display(Name="Reseña")]
    [Required]
    public string Review {get; set;}
}   