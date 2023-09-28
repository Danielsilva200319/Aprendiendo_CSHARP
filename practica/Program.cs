internal class Program
{
    private static void Main(string[] args)
    {
        // Programa que calcula el área de un rectangulo.
        double LadoA;
        double LadoB;
        double resultado;

        Console.WriteLine("Calcula el área de un rectangulo");
        Console.Write("\nIngrese el valor del lado A: ");
        LadoA = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nIngrese el valor del lado B: ");
        LadoB = Convert.ToDouble(Console.ReadLine());
        resultado = LadoA * LadoB;
        Console.WriteLine("\nEl resultado es: " + resultado);
    }
}