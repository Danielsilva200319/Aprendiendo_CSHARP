// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var poderVolar = new SuperPoderes();
    poderVolar.Nombre = "Volar";
    poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
    poderVolar.Nivel = (int)NivelPoder.NivelDos;
var SuperFuerza = new SuperPoderes();
    SuperFuerza.Nombre = "Super Fuerza";
    SuperFuerza.Nivel = (int)NivelPoder.NivelTres;

var Superman = new HeroesApp();
    Superman.Id = 1;
    Superman.Nombre = "Superman";
    Superman.IndentidadSecreta = "Clark Kent";
    Superman.Ciudad = "Metropolis";
    Superman.PuedeVolar = true;
var Batman = new HeroesApp();
    Batman.Id = 2;
    Batman.Nombre = "Batman";
    Batman.IndentidadSecreta = "Bruce Wayne";
    Batman.Ciudad = "Gotham City";
    Batman.PuedeVolar = false;
var CapitanaMarvel = new HeroesApp();
    CapitanaMarvel.Id = 3;
    CapitanaMarvel.Nombre ="Capitana Marvel";
    CapitanaMarvel.IndentidadSecreta = "Carol Denvers";
    CapitanaMarvel.Ciudad = "Kree";
    CapitanaMarvel.PuedeVolar = true;

List<SuperPoderes> poderSuperman = new List<SuperPoderes>();
    poderSuperman.Add(poderVolar);
    poderSuperman.Add(SuperFuerza);
    Superman.SuperPoderes = poderSuperman;
List<SuperPoderes> poderCapitanaMarvel = new List<SuperPoderes>();
    poderCapitanaMarvel.Add(poderVolar);
    poderCapitanaMarvel.Add(SuperFuerza);
    Superman.SuperPoderes = poderCapitanaMarvel;

class HeroesApp
{
    public int Id;
    public string Nombre;
    public string IndentidadSecreta;
    public string Ciudad;
    public List<SuperPoderes> SuperPoderes;
    public bool PuedeVolar; 
}
class SuperPoderes
{
    public string Nombre;
    public string Descripcion;
    public int Nivel;
}
enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}