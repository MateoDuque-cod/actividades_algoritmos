using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        // 22. Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes
        // y luego lo clasifique dentro de una categoría:
        //- Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.
        //- Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
        //- Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
        //- Si el IMC es mayor de 29.9 entonces tiene obesidad.
        //Mostrar en pantalla la categoría de cada uno de los pacientes.
        //La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular

        double estatura, peso, imc;
        bool continuar = true;
        int n,i;
        string  respuesta;
        while (continuar)
        {
            Console.WriteLine("ingrese el numero de pacientes");
            n = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"ingrese el peso del paciente numero # {i +1} en kg");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"ingrese la estatura del paciente numero # {i + 1} en metros");
                estatura = Convert.ToDouble(Console.ReadLine());


                imc = peso / Math.Pow(2, estatura);

                switch (imc)
                    
                {
                    case double cat when cat < 18.5:
                        Console.WriteLine($"el paciente con el IMC: {imc} esta en la categoria de peso insuficiente");

                    break;

                    case double cat when cat >= 18.5 && cat < 25:
                        Console.WriteLine($"el paciente con el IMC: {imc} esta en la categoria de peso saludable");
                        break;

                    case double cat when  cat >= 25 && cat < 30:
                        Console.WriteLine($"el paciente con el IMC: {imc} esta en la categoria de sobrepeso");
                        break;

                    case double cat when cat >= 30:
                        Console.WriteLine($"el paciente con el IMC: {imc} esta en la categoria de obesidad");
                        break;

                    default:
                        Console.WriteLine("el paciente no se encuentra en ninguna categoria.");
                        break;
                }


            }
            Console.WriteLine();
            Console.WriteLine("Desea calcular el peso de mas pacientes? si para continuar, no para terminar.");
            respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "SI")
            {
                continuar = true;
            }
            else
            {
                Console.WriteLine("calulo terminado.");
                continuar= false;
            }
        }
    }
}