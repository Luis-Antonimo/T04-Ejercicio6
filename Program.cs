using System;

namespace T04Ejercicio6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba el precio de un producto:");
            int precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique la forma de pago (efectivo o tarjeta):");
            string formaPago = Console.ReadLine();
            switch (formaPago)
            {
                case "efectivo":
                    Console.WriteLine("El pago de" + precio + "€ se realizará en efectivo.");
                    break;
                case "tarjeta":
                    Console.WriteLine("Indique el número de tarjeta:");
                    string numeroTarjeta = Console.ReadLine();
                    Console.WriteLine("El pago de " + precio + "€ se realizará con la tarjeta número " + numeroTarjeta + ".");
                    break;
                //default se utiliza para indicar si ha habido un error 
                default:
                    Console.WriteLine("Lo que has escrito no corresponde con un modo de pago.");
                    break;
            }
        }
    }
}