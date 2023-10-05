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
/* 
var radio = 0d;
var resultado = 0d;
const double Pi =3.14;
Console.WriteLine("Bienbenidos, Vamos a calcular círculos");
// pi * radio * radio
Console.Write("\nIngrese el valor de radio: ");
radio = Convert.ToDouble(Console.ReadLine());
resultado = Pi * radio * radio;
Console.WriteLine("\nEl área de tu círculo es de: " + resultado); 
*/
/* 
int totalJugador = 25;
int totalDealer = 15;
string message = "";
//Blackjack, Juntar 21 pidiendo cartas o en caso de tener menos de 21 igual tener mayor puntuación que el dealer.
if (totalJugador > totalDealer && totalJugador < 22)
{
    message = "Venciste al Dealer, Felicidades";
}
else if (totalJugador >= 22)
{
    message = "Perdiste vs el Dealer, Sorry, te pasaste de 21";
}
else if (totalJugador <= totalDealer)
{
    message = "Perdiste vs el Dealer, Sorry";
}
else
{
    message = "Condición no válida";
}
Console.WriteLine(message); 
*/
System.Random random = new System.Random();
int totalJugador = 0;
int totalDealer = 0;
int num = 0;
string message = "";
string switchControl = "Menu";
string controlOtraCarta = "";
//Blackjack, Juntar 21 pidiendo cartas o en caso de tener menos de 21 igual tener mayor puntuación que el dealer.
while (true)
{
    totalJugador = 0;
    totalDealer = 0;

    switch (switchControl)
    {
        case "Menu":
            Console.WriteLine("Welcome to CASINO");
            Console.Write("Escriba '21' para jugar al 21: ");
            switchControl = Console.ReadLine();
            break;
        case "21":
            do
            {
                num = random.Next(1, 12);
                totalJugador = totalJugador + num;
                Console.WriteLine("\nToma tu carta, Jugador");
                Console.WriteLine($"Te salio el: {num}");
                Console.WriteLine("\n¿Deseas otra carta?");
                controlOtraCarta = Console.ReadLine();
            }
            while (controlOtraCarta == "Si" || controlOtraCarta == "si" || controlOtraCarta == "yes");
            totalDealer = random.Next(15, 21);
            Console.WriteLine($"\nEl dealer tiene {totalDealer}!");
            if (totalJugador > totalDealer && totalJugador < 22)
            {
                message = "Venciste al Dealer, Felicidades\n";
                switchControl = "Menu";
            }
            else if (totalJugador >= 22)
            {
                message = "Perdiste vs el Dealer, Sorry, te pasaste de 21\n";
                switchControl = "Menu";
            }
            else if (totalJugador <= totalDealer)
            {
                message = "Perdiste vs el Dealer, Sorry\n";
                switchControl = "Menu";
            }
            else
            {
                message = "Condición no válida\n";
                switchControl = "Menu";
            }
            Console.WriteLine(message);
            break;
        default:
            Console.WriteLine("Valor ingresado no válido\n");
            switchControl = "Menu";
            break;
    }
}
