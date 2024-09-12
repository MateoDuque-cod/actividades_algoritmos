public class Program
{
    private static void Main(string[] args)
    {
        // construir un programa que pida por pantalla 3 numeros y luego diga cual es el mayor, el del medio y el menor de los numeros asignado //
        int a, b, c;

        Console.WriteLine("Ingrese el primer número:");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        c = Convert.ToInt32(Console.ReadLine());

        int medio, mayor, menor;


        if (a >= b && a >= c)
        {
            mayor = a;
            if (b >= c)
            { medio = b; menor = c; }
            else
            { medio = c; menor = b; }
        }
        else if (b >= a && b >= c)
        {
            mayor = b;
            if (a >= c)
            { medio = a; menor = c; }
            else
            { medio = c; menor = a; }
        }
        else
        {
            mayor = c;

            if (a >= b)
            { medio = a; menor = b; }
            else
            { medio = b; menor = a; }
        }
        Console.WriteLine("El numero mayor es: " + mayor);
        Console.WriteLine("El numero medio es: " + medio);
        Console.WriteLine("El numero menor es: " + menor);
    }
}
