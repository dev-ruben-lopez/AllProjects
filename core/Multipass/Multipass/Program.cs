using System;
using System.Threading.Tasks;

namespace Multipass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DoOne(10);
            Console.Write("Resultado ?");
            Console.Read();

        }

        
        static async void DoOne(int param)
        {
            await Task.Delay(10000);
            Console.Write("El resultado es : " + (param * 21).ToString()) ;
        }
    }
}
