using System;

namespace Aula25_Sprint4_Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();
            
            rec.GerarSequenciaFibonacci(0,1,20);

            System.Console.WriteLine(rec.GerarFatorial(5));

            rec.GerarSequenciaTribonacci(0,1,2,10);
        }
    }
}
