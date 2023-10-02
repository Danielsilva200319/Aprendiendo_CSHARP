internal class Program
{
    private static void Main(string[] args)
    {
        // Programa que calcula el área de un rectangulo.
        // var LadoA = 1.1;
        // var LadoB = 1.1;
        // var resultado = 1.1;

        // Console.WriteLine("Calcula el área de un rectangulo");
        // Console.Write("\nIngrese el valor del lado A: ");
        // LadoA = Convert.ToDouble(Console.ReadLine());
        // Console.Write("\nIngrese el valor del lado B: ");
        // LadoB = Convert.ToDouble(Console.ReadLine());
        // resultado = LadoA * LadoB;
        // Console.WriteLine("\nEl resultado es: " + resultado);
        var radio = 0d;
        var resultado = 0d;
        const double Pi =3.14;
        Console.WriteLine("Bienbenidos, Vamos a calcular círculos");
        // pi * radio * radio
        Console.Write("\nIngrese el valor de radio: ");
        radio = Convert.ToDouble(Console.ReadLine());
        resultado = Pi * radio * radio;
        Console.WriteLine("\nEl área de tu círculo es de: " + resultado);
    }
}