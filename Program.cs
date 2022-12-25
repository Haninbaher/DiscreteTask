using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace haneen_baher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number but greater than 1");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last number ");
            int y = int.Parse(Console.ReadLine());

            for (int n= x; n <= y; n++)
            { int i;

                for ( i = 2; i < n; i++)
                {
                    if (n % i == 0)

                        break;
                }
                if (i >= n)
                    Console.WriteLine(n);
                }
                

            }
            

         






        }
        




    } 


