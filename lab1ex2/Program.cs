using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va calcula media aritmetica a trei numere citite de la
            tastatura*/

            Console.WriteLine("Calculam media aritmetica a trei numere");
            Console.WriteLine("Introduceti primul numar");
            
            double primulNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar");

            double alDoileaNumar = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar");

            double alTreileaNumar = int.Parse(Console.ReadLine());

            double mediaAritmetica = (primulNumar + alDoileaNumar + alDoileaNumar) / 3;

            Console.WriteLine("Media aritmetica a celor trei numere este: " + mediaAritmetica);

        }
    }
}
