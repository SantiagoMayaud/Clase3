using Clase3.Models;
using Clase3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase3.Pages
{ //está página es donde se van a ver los detalles de una pelicula elegida
    public class MovieDetailModel : PageModel
    {
        public Movie MovieDetail {get; set;} = new();
        public void OnGet(string code) //Al cargarse la página con la llamada "get", va a recibir como parametro el código de la pelicula
        {
            if (code != null){
                var responseServiceData = MovieService.Get(code);//con el metodo "get" de MovieService, va a buscar ese código en la lista de peliculas
                if(responseServiceData != null){
                    MovieDetail = responseServiceData; //una vez encontrado, va a asignarlo a responseServiceData y a MovieDetail
                }
            }
        }

        public IActionResult OnPostDelete(string code){
            if(code != null){
                MovieService.Delete(code);
            }

            return RedirectToPage("Index");
        }
    }
}
