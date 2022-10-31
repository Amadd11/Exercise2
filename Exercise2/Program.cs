using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class BubbleSort
    {
        //deklarasi array int dengan ukuran 20
        private int[] a = new int[52];

        //Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;

        // Fungsi / method atau menerima masukan
        public void Read()
        {
            while (true)
            {
                Console.WriteLine("Masukkan Banyak Elemen pada Array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 52)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunya maksimal 52 elemen.\n");

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
