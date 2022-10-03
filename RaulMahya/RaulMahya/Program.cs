using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaulMahya
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ayam;
            Console.Write("ANAK AYAM TURUN");
            ayam = int.Parse(Console.ReadLine());

            if(ayam > 10 || ayam <= 0)
            {
                Console.WriteLine("tidak sesuai");
            }
            else
            {
                for (int i = ayam; i >= 1; i--)
                {

                    

                    if(i == 1)
                    {
                        Console.WriteLine("lebih dari ayam 1 " + "mati satu tinggal idnuknya");
                    }
                    else
                    {
                        Console.WriteLine("lebih dari ayam " + i + "," + "Matilah satu tinggalah " + (i - 1));
                    }
                    
                }
            }
            

            


            /* int angka;
             int jumlah;

             angka = 80889999;
             jumlah = 0;

             Console.WriteLine("angka: " +angka);
             while (angka > 0)
             {
                 jumlah++;
                 angka = angka / 10;
             }
             Console.WriteLine("jumlah digit:" + jumlah); */

            /*  int angka;
              int digit;
              angka = 479;
              Console.WriteLine("Angka: " + angka);
              Console.Write("Angka terbalik: ");

              do
            {
                  digit = angka % 10;
                  Console.Write(digit);
                  angka = angka / 10;

              } while (angka > 0);
              Console.WriteLine(); */

           /* string matkul = "PEMPROGRAMAN";
            foreach (char mk in matkul)
            {
                Console.Write($"[{mk}] ");
            } */
            /*string[] arrayNama = new string[] { "dadang", "susep", "bobi" };
            foreach (string oi in arrayNama)
            {
                Console.WriteLine(oi);
            }*/
           /* for(int i = 0; i<2; i++)
            {
                for(int j = 0; j< 2; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            } */

            
        }
    }
}
