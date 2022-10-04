using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_1214078
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool finished = false;

            do 
            {
                Console.WriteLine("MENU PERSEGI PANJANG\n");
                Console.WriteLine("1. HITUNG LUAS\n");
                Console.WriteLine("2. HITUNG KELILING \n");
                Console.WriteLine("***************\n\n");

                int pilih;
                Console.WriteLine("Menu Pilihan : ");

                double panjang, lebar, hasil;
                hasil = 0;

                pilih = int.Parse(Console.ReadLine());

                if (pilih < 1 || pilih > 2)
                {
                    Console.WriteLine("********Menu tidak tersedia********");
                }

                switch (pilih)
                {
                    case 1:
                        Console.WriteLine("\n========MENGHITUNG LUAS PERSEGI PANJANG========");
                        Console.Write("Masukkan panjang (cm) : ");
                        panjang = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan lebar (cm)   : ");
                        lebar = double.Parse(Console.ReadLine());
                        hasil = panjang * lebar;
                        Console.WriteLine("\nLuas Persegi Panjang Adalah =  {0} cm", hasil);
                        break;

                    case 2:
                        Console.WriteLine("\n========MENGHITUNG KELILING PERSEGI PANJANG========");
                        Console.Write("Masukkan panjang (cm) : ");
                        panjang = double.Parse(Console.ReadLine());
                        Console.Write("Masukkan lebar (cm)   : ");
                        lebar = double.Parse(Console.ReadLine());
                        hasil = (2 * panjang) + (2 * lebar);
                        Console.WriteLine("\nKeliling Persegi Panjang Adalah =  {0} cm", hasil);
                        break;
                }

                Console.WriteLine("\n\nIngin Mengulangi Kembali? (Y/T)?");
                char c = char.Parse(Console.ReadLine());

                if (c == 'y')
                {
                    finished = false;
                }
                else
                {
                    finished = true;
                }
                Console.Clear();
            } while (!finished);
        }
                
            
        }
    }
    
    

