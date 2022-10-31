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
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Masukkan elemen Array");
            Console.WriteLine("---------------------------------------------------------");

            //Memasukkan elemen pada array
            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s = Console.ReadLine();
                a[i] = Int32.Parse(s);
            }
        }
        public void Display()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" Element array yang tersusun");
            Console.WriteLine("----------------------------------------------");
            for (int ms = 0; ms < n; ms++)
            {
                Console.WriteLine(a[ms]);

            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                //pada spasi i, bandingkan n -1 elemenn pertama dengan elemen selanjutnya
                for (int ms = 0; ms < n - i; ms++)
                {
                    if (a[ms] > a[ms + 1]) //jika elemen tidak ada dalam ururtan  yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = a[ms];
                        a[ms] = a[ms + 1];
                        a[ms + 1] = temp;

                    }
                }
            }
        }
        public void MergeSort(int[] numbers, int low, int mid, int high)
        {
            int[] temp = new int[52];
            int i, ms, num, pos;
            ms = (mid - 1);
            pos = low;
            num = (high - low + 1);

            while ((low <= ms) && (mid <= high))
            {
                if (numbers[low] <= numbers[mid])
                    temp[pos++] = numbers[low++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (low <= ms)
                temp[pos++] = numbers[low++];
            while (mid <= high)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[high] = temp[high];
                high--;
            }
        }
        

        static void Main(string[] args)
        {
        }
    }
}
