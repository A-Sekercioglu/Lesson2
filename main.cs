using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
        basla:
            if(i >= 10000) //eğer i 10000 den büyük veya ona eşitse a noktasına gitsin
            {
                goto a;
            }
            i++;
            if ((i < 10000) && (i*i == i*i*i))//eğer i sayısının karesi ve küpü birbirine eşitse i sayısını ekrana yaz ve başlangıca git
                
            {
                Console.WriteLine(i);
                goto basla;
            }
            else //eğeri sayısının karesi ve küpü birbirine eşit değilse başlangıca git
            {
                goto basla;
            }
            a:
            Console.ReadKey();
        }
    }
}
