public class Program
{
    private static void Main(string[] args)
    {
        /*15. programe un algoritmo que pida al usuario 2 numeros por pantalla y que muestre
         * todos los numeros comprendidos entre ambos numeros incluyendolos*/

        int num1, num2;
        int menor, mayor;

        Console.Write("ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            menor = num2;
            mayor = num1;
        }
        else
        {
            menor = num1;
            mayor = num2;
        }
        Console.WriteLine("los numeros entre el numero 1 y numero 2 son: ");

        for (int i = menor; i <= mayor; i++)
        {
            // Console.WriteLine(i); imprime por filas
            Console.Write($"{i}  "); // imprime derecho con espacio: 1  2  3  4....

        }

    }

}