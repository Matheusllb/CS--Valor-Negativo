using System;

namespace CsE7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Desobrindo valor negativo\n\nINFORME UM VALOR: ");
            int valor = int.Parse(Console.ReadLine());
            //SE VALOR É MENOR QUE ZERO É NEGATIVO
            if (valor < 0)
                Console.WriteLine("\nNEGATIVO");
            else
                Console.WriteLine("\nNAO NEGATIVO!");
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
