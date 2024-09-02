public class Program
{
    private static void Main(string[] args)
    {
     double x1 , y1, x2, y2, d;

        Console.WriteLine("ingrese coordenada para x1");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ingrese coordenada para x2");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ingrese coordenada para y1");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ingrese coordenada para y2");
        y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("La distancia entre los pares ordenados (" +x1 + "," + y1 + ") y (" +x2 +"," + y2 + ") es: "+ d);
        Console.WriteLine();
    }

}