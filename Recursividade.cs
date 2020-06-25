using System;

namespace Aula25_Sprint4_Recursividade
{
    public class Recursividade
    {
        
        public void GerarSequenciaFibonacci(int num1, int num2, int vezes){
            
            if(vezes >= 0){
                Console.WriteLine(num1);
                GerarSequenciaFibonacci(num2, num1 + num2, vezes -1);
            }

        }

        public int GerarFatorial(int numero){
            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero -1);
            }

        }
        
        public void GerarSequenciaTribonacci(int num1, int num2, int num3, int vezes){
            
            if(vezes >= 0){
                Console.WriteLine(num1);
                GerarSequenciaTribonacci(num2, num3, num1 + num2 + num3, vezes -1);
            }

        }
    }
}