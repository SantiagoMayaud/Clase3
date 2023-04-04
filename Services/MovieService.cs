using Clase3.Models; //importamos el namespace de la carpeta Models para que este programa use todo lo que está dentro de esa carpeta

namespace Clase3.Services;

public static class MovieService {
    static List<Movie> Movies {get; set;} //Esto significa que la clase estática MovieService tiene una lista de objetos de tipo Movie

    static MovieService(){
        Movies = new List<Movie>
        {
            new Movie { Name = "Back to the Future", Code = "BTF", Category = "Sci Fi", Minutes=120},
            new Movie { Name = "Avatar", Code = "AVT", Category = "Sci Fi", Minutes=500, Review="Cinco estrellas"},
            new Movie { Name = "Hannibal", Code = "HNL", Category = "Terror", Minutes=110},
        };
    }
    public static List<Movie> GetAll() => Movies; //Este metodo devuelve todos los items de la lista Movies

//Como agregar un elemento "Movie" a la lista:
public static void Add(Movie obj){ //Add es un metodo predeterminado
    if(obj == null){
        return;
    }
    Movies.Add(obj);
}

    public static void Delete(string code){ //Este es un metodo que recibe el código de una pelicula
        var movieToDelete = Get(code); //Esta es una variable que toma el código enviado

        if (movieToDelete != null){ //Si el código no es null, si tiene algo...
            Movies.Remove(movieToDelete);//Entonces se remueve la pelicula de la lista Movies
        }
    }

    //Ahora tenemos que programar una forma para encontrar peliculas dentro de la lista.
    public static Movie? Get(string code) => Movies.FirstOrDefault( x => x.Code.ToLower() == code.ToLower()); 
    
    //Este código devuelve el primer elemento que encuentra que cumple las condiciones ingresadas en el parentesis. En este caso, la condición es que el Code de x sea igual al code que está dentro de la lista. EL ToLower sirve para que no sea case sensitive.
}