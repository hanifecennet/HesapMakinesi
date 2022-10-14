using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {

            //Toplama İŞlemei
            
            Console.WriteLine("Toplama işleminin sonucu: " + Toplama(3,5));//çağrıldığı yer
        }

        //Toplama işlemi

        static  int Toplama(int sayi1, int sayi2) //metot tanımlandı
        {
            return sayi1 + sayi2;
        }
    }
}
