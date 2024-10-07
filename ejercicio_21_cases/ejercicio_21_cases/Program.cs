using System.Reflection;

public class Program
{
    private static void Main(string[] args)
    {
        /*21. Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará 
         * alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 
         * los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen 
         * (validar división por cero). Independientemente de la selección, imprima el resultado. Además, el programa 
         * debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación
         * aritmética o digitar cero para finalizar el programa. DONE*/
        
        double num1, num2;
        int opcion;
        double resultado =0;
        bool continuar = true;
        string salir = null;
        do
        {
            Console.WriteLine("______________________________________");
            Console.WriteLine("|        BIENVENIDO AL MENÚ          |");
            Console.WriteLine("|____________________________________|");
            Console.WriteLine("|Acontinuacion seleccione una opcion:|");
            Console.WriteLine("|____________________________________|");
            Console.WriteLine("|1. SUMA                             |");
            Console.WriteLine("|____________________________________|");
            Console.WriteLine("|2. RESTA                            |");
            Console.WriteLine("|____________________________________|");
            Console.WriteLine("|3. MULTIPLICACION                   |");
            Console.WriteLine("|____________________________________|");
            Console.WriteLine("|4. DIVISION                         |");
            Console.WriteLine("|____________________________________|");
            Console.WriteLine("|0. SALIR                            |");
            Console.WriteLine("|____________________________________|");
            Console.WriteLine();
            opcion = int.Parse(Console.ReadLine());


            Console.Write("ingrese primer numero: ");
            num1 = Double.Parse(Console.ReadLine());

            Console.Write("ingrese segundo numero: ");
            num2 = Double.Parse(Console.ReadLine());


            switch (opcion)
            {       
                case 1:
                    resultado = num1 + num2;
                    Console.Write($"la suma entre {num1} y {num2} es:{resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.Write($"la resta entre {num1} y {num2} es:{resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.Write($"la multiplicacion entre {num1} y {num2} es:{resultado}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.Write($"la division entre {num1} y {num2} es: { resultado}");
                    }
                    else
                    {
                        Console.WriteLine("error no se puede divir por cero");
                    }
                    break;
                case 0:
                    Console.WriteLine("te has salido del programa");
                    continuar = false;
                    break;

                default:

                    Console.WriteLine("esta opcion no esta en el menu");
                    continuar = false;

                    break;
            }
            Console.WriteLine();
            Console.WriteLine("    deseas realizar otra operacion ? si para continuar, no para finalizar");
            salir = Console.ReadLine().ToUpper();


            if (salir == "SI")
            {
                continuar = true;
            }
            else if (salir == "NO")
            {
                Console.WriteLine("te has salido del programa, Adios!");
                continuar = false;
            }
            else
            {
                Console.WriteLine("opcion no valida");
            }
        }
        while (continuar);  
        
    }
}