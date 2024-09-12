public class Program
{
    private static void Main(string[] args)
    {
        //Arreglar identación Ctrl + K, Ctrl + D
        //2.Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.

        //Delcaración de los inputs
        double seg1, seg2, seg3;
        bool isTriangle;
        string msj;

        //Pedir los datos - input:
        Console.Write("Ingrese el primer segmento: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //Proceso - Validación
        //Validación en cascada
        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {
                if ((seg2 + seg3) > seg1)
                {
                    isTriangle = true;
                }
                else
                {
                    isTriangle = false;
                }
            }
            else
            {
                isTriangle = false;
            }
        }
        else
        {
            isTriangle = false;
        }

        //Validación en una sola línea
        if (((seg1 + seg2) > seg3) && ((seg1 + seg3) > seg2) && ((seg2 + seg3) > seg1))
        {
            isTriangle = true;
        }
        else
        {
            isTriangle = false;
        }

        //Mostrar mensaje - output
        if (!isTriangle)
        {
            Console.Write("No se puede construir el triángulo");
        }
        else
        {
            Console.Write("Se puede construir el triángulo");
        }
    }
}
