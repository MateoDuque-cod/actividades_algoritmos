using System.Runtime.InteropServices;

public class Program
{
    static void Main(string[] args)
    {
        //13. Solicite los parámetros necesarios para resolver una ecuación de 2do grado por medio de la ecuación cuadrática general.
        //El algoritmo retornará las soluciones reales (x1 y x2). Si la ecuación no tiene solución, debe justificar el motivo que no permite
        //resolverla. Pruebe su solución con las siguientes ecuaciones:
        //(-2𝑥)(-2x)−5𝑥−3 = 0

        double a, b, c, discriminante;

        Console.Write("soluciones para la ecuacion: Ax^2 + Bx + C.");
        Console.WriteLine();
        Console.Write("ingrese el valor de a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de c: ");
        c = Convert.ToDouble(Console.ReadLine());

        discriminante = (b * b) - 4 * a * c ;

        if (discriminante > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

            Console.Write("tiene 2 soluciones reales, su determinante es: " + discriminante);
            Console.WriteLine();
            Console.WriteLine($"Las soluciones reales son: x1 = {x1} y x2 = {x2}");

        }

        else if (discriminante < 0)
        { 
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            
                Console.Write("no tiene soluciones reales, son complejas, su determinante es: " + discriminante);
                Console.WriteLine();
                Console.Write($"Las soluciones reales son: x1 = {x1} y x2 = {x2}");
        }

        else 
        {
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            
            Console.Write("solo tiene una solucion real, su determinante es: "+ discriminante);
            Console.WriteLine();
            Console.Write($"Las soluciones reales son: x1 = {x1} y x2 = {x2}");

        }
    }

}