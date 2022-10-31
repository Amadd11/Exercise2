using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
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
        public void SortMergeArray(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMergeArray(numbers, left, mid);
                SortMergeArray(numbers, (mid + 1), right);
                MergeSort(numbers, left, (mid + 1), right);
            }
        }
        public void Displayy() 
        {
            Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
            Console.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input int array : ");
            Console.Write("\n");
            for (int k = 0; k < max; k++)
            {
                Console.Write(numbers[k] + " ");
                Console.Write("\n");
            }
            Console.WriteLine("MergeSort By Recursive Method");
            SortMergeArray(numbers, 0, max - 1);
            for (int i = 0; i < max; i++)
                Console.WriteLine(numbers[i]);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("==================");
                Console.WriteLine("1.BubbleSort");
                Console.WriteLine("2.MergeSort");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice (1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine(".....................");
                        Console.WriteLine("BubbleSort");
                        Console.WriteLine(".....................");
                        myList.Read();
                        myList.Display();
                        myList.BubbleSortArray();
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine(".....................");
                        Console.WriteLine("MergeSort");
                        Console.WriteLine(".....................");
                        myList.Displayy();
                        break;
                    case 3:
                        Console.WriteLine("exit.");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                //to exit from the console
                Console.WriteLine("\n\nPress Return to exit.");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
        
