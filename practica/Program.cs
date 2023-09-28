internal class Program
{
    private static void Main(string[] args)
    {
        // Programa que calcula el área de un rectangulo.
        int LadoA;
        int LadoB;
        int resultado;

        Console.WriteLine("Calcula el área de un rectangulo");
        Console.Write("\nIngrese el valor del lado A: ");
        LadoA = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nIngrese el valor del lado B: \n");
        LadoB = Convert.ToInt32(Console.ReadLine());
        resultado = LadoA * LadoB;
        Console.WriteLine("El resultado es: " + resultado);
    }
}