public class Program
{
    private static void Main(string[] args)
    {
        // CONSTRUIR UN ALGORITMO QUE PIDA N NUMEROS POR PANTALLA,CUANDOEL USUARIO INGRESE UN NUMERO NEGATIVO
        // DEBE FINALIZAR Y MOSTRAR EN CONSOLA LA CANTIDAD TOTAL DE NUMEROS POSITIVOS QUE INGRESO 
        // HASTA ANTES DEL NUM NEGATIVO QUE INGRESO

        int contador = 0;
        bool bandera = true;
        int num;

        while (bandera)
        {
            Console.Write("ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                //contador = contador + 1; //forma clasica
                contador++; // forma elegante
            }
            else
            {
                bandera = false;
            }
        }
        Console.Write($"El total de numeros positivos ingresados es de: {contador}");
    }
}
