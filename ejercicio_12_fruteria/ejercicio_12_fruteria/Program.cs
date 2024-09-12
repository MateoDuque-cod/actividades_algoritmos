internal class Program
{
    private static void Main(string[] args)
    {
        //Declaración de constantes:
        const decimal precioKiloManzana = 5000;
        decimal descuento, precioBruto, precioNeto, precioDescuento;

        //Una frutería ofrece las manzanas con descuento según la siguiente tabla: 
        //Usted determina el precio del kilo de manzanas como desarrollador. Determinar y mostrar cuánto pagará una persona que compre manzanas es esa frutería y cuál descuento fue el que se le aplicó, si fue que se le aplicó alguno.

        //Datos de Entrada: Cantidad de kilos de manzanas
        //Proceso: Calcular el valor neto de manzanas y luego aplicarle descuento si es que le aplica
        //Datos de salida: valor total y descuento aplicado

        Console.Write("Ingrese la cantidad de kilos de manzanas a comprar: ");
        decimal kilosManzanas = Convert.ToDecimal(Console.ReadLine());

        //Cálculos

        if (kilosManzanas >= 0 && kilosManzanas <= 2)
        {
            descuento = 0;
        }
        else if (kilosManzanas > 2 && kilosManzanas <= 5)
        {
            descuento = 10;
        }
        else if (kilosManzanas > 5 && kilosManzanas <= 10)
        {
            descuento = 15;
        }
        else
        {
            descuento = 20;
        }

        //Cálculo del precio bruto
        precioBruto = precioKiloManzana * kilosManzanas;

        //Cálculo del descuento
        precioDescuento = precioBruto * (descuento / 100);

        //Cálculo del precio neto
        precioNeto = precioBruto - precioDescuento;

        //Mostrar los resultados:
        Console.WriteLine($"El total a pagar por {kilosManzanas} kilos es de : {precioNeto:C0}");
        Console.WriteLine($"Se ha aplicado un descuento del {descuento}% que equivale a {precioDescuento:C0}");
        // la notación C es parapintar los números en términos de dinero, y el cero, es para quitar los decimales.
    }
}