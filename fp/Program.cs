﻿using fp.AbstractionClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..5]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4:
                        ContohPenjualan();
                        break;

                    case 5: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Write("\n=============================");
            Console.Write("\n| Contoh Aplikasi Penjualan |");
            Console.Write("\n=============================");
            Console.WriteLine("\n");
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.Write("\n");
            Console.WriteLine("1. Tambah Penjualan \n2. Hapus Penjualan \n3. Tampil Penjualan \n4. Deskripsi Penjualan \n5. Keluar");
        }

        static void TambahPenjualan()
        {
            
            Penjualan penjualan = new Penjualan(); //contoh objek class
            //penjualan.Nota1 = 1; //untuk mengakses field enkapsulasi
            Console.Clear();

            Console.WriteLine("Tambah Data Penjualan");
            Console.Write("\nNota: ");
            penjualan.Nota = Convert.ToInt32(Console.ReadLine());
            //penjualan.Nota1 = Convert.ToInt32(Console.ReadLine()); //untuk mengakses field enkapsulasi

            Console.Write("Tanggal: ");
            penjualan.Tanggal = Console.ReadLine();

            Console.Write("Customer: ");
            penjualan.Customer = Console.ReadLine();

            Console.Write("Jenis [T/K]: ");
            string jenis = Console.ReadLine();

            penjualan.Jenis = jenis == "T" ? "Tunai" : "Kredit";

            Console.Write("Total Nota: ");
            penjualan.TotalNota = Convert.ToInt32(Console.ReadLine());

            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
            bool status = false;

            Console.WriteLine("\nHapus Data Penjualan");
            Console.Write("");
            Console.Write("\nNota: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                if (nota == daftarPenjualan[i].Nota) //untuk mengakses field enkapsulasi Nota diganti Nota1
                {
                    daftarPenjualan.Remove(daftarPenjualan[i]);
                    status = true;
                    break;
                }
                else
                {
                    status = false;
                }
            }

            if (status)
            {
                Console.WriteLine("\nData Penjualan berhasil di hapus", nota);
            }
            else
            {
                Console.WriteLine("\nNota tidak ditemukan", nota);
            }

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection

            Console.WriteLine("Data Penjualan");

            if (daftarPenjualan.Count > 0)
            {
                for (int i = 0; i < daftarPenjualan.Count; i++)
                {
                    Console.WriteLine(" {0}. {1}, {2}, {3}, {4}, {5}", i + 1, daftarPenjualan[i].Nota, daftarPenjualan[i].Tanggal, daftarPenjualan[i].Customer, daftarPenjualan[i].Jenis, daftarPenjualan[i].TotalNota);
                }  //untuk mengakses field enkapsulasi Nota diganti Nota1
            }
            else
            {

                Console.WriteLine("\nTidak Ada Data Penjualan");
            }


            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }

        static void ContohPenjualan() //deklarasi abstraction
        {
        
            abstrac abstrac1;

            abstrac1 = new costumer();
            abstrac1.pembeli();
            abstrac1.transaksi();
            abstrac1.bayar();

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
