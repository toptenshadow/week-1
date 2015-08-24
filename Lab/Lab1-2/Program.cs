using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
       static int[] input()
        {
            
            int b;
            Console.WriteLine("input how many number");
            b = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[b];

            for (int i = 0; i < b; i++)
            {
                int x = i + 1;
                Console.WriteLine("number" + x);


                // input
                
                int c = Convert.ToInt32(Console.ReadLine());
                a[i] = c;
            }
        
            return a;
        }
        static int[] process(int[] input)
        {
            bool flag = true;
           
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] < input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }

            }
            return input;
          }
      
        static void output(int[] number){

            foreach (int i in number){
                Console.Write(i);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
        static void Main(string[] args){

            output(process(input()));
        }
    }
}
