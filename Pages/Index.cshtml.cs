using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Clase3.Models;
using Clase3.Services;

namespace Clase3.Pages;

public class IndexModel : PageModel
{
    public List<Movie> MovieList {get; set;}
    
    [BindProperty] //Sirve para mapear la propiedad. Al hacer una llamada post, cada propiedad se va a unir con la propiedad correspondiente de la clase. Los nombres con los nombres, etc.
    public Movie NewMovie {get; set;}
    public IndexModel()
    {
        //Constructor del Page Model
    }

    public void OnGet() //Este método es lo que la página va a hacer cuando se carge, cuando el usuario haga una llamada "get"
    {
        MovieList = MovieService.GetAll();
    }

    public IActionResult OnPost(){
        if(!ModelState.IsValid) { //Esta linea verifica que el modelo de la página es valido, que todas sus propiedades cumplen con el código. Por ejemplo, las etiquetas Required. 
            return RedirectToPage("/Error"); //Esta orden hace que, si el modelo de la página es invalido, se rediriga al usuario a la página de error.
        } 

        MovieService.Add(NewMovie); //Si el modelo es valido, se agrega una nueva pelicula mediante la propiedad que está bindeada

        return RedirectToAction("get");
    }
}
