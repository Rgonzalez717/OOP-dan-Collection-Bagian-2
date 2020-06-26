using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_dan_collection.ClassInduk;
using oop_dan_collection.ClassAnak;

namespace oop_dan_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 9 (Pertemuan 11) -  & Collection #2";
                  

            //objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();           

            void tampil_karyawan()
            {
                Console.WriteLine("\n");
                int noUrut = 1;
                
                    foreach (Karyawan karyawan in listKaryawan)
                    {

                        Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}, {4}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji(), karyawan.tipe_karyawan);

                        noUrut++;
                    }              
                               
            }

            void tambah_kary_tetap(string tipe_kary, string nik, string nama, int gaji_bulanan)
            {
                
                    listKaryawan.Add(new KaryawanTetap { Nik = nik, Nama = nama, GajiBulanan=gaji_bulanan, tipe_karyawan = tipe_kary });
                                               
            }

            void tambah_kary_harian(string tipe_kary, string nik, string nama, int upah_perjam, int jumlah_jam_kerja)
            {
                    listKaryawan.Add(new KaryawanHarian { Nik = nik, Nama = nama, UpahPerJam = upah_perjam, JumlahJamKerja=jumlah_jam_kerja, tipe_karyawan = tipe_kary });
            }

            void tambah_sales(string tipe_kary, string nik, string nama, int jumlah_jual, int komisi)
            {
                             
                listKaryawan.Add(new Sales { Nik = nik, Nama = nama, JumlahPenjualan=jumlah_jual, Komisi=komisi, tipe_karyawan = tipe_kary });

            }

            void hapus_karyawan()
            {
                int no = 1;
                int jumlah_kary = 0;

                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. Nik: {1}", no, karyawan.Nik);

                    no++;
                    jumlah_kary += 1;
                }

                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jumlah_kary);
                Console.Write("] : ");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik - 1;

                listKaryawan.RemoveAt(index_nik);
                Console.WriteLine("Data Karyawan Berhasil Dihapus ");
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }




            bool keluar = false;

            while(keluar==false)
            {

            Console.WriteLine("\n");
            Console.WriteLine("Pilih menu Aplikasi");
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Hapus Data");
            Console.WriteLine("3. Tampil Data");
            Console.WriteLine("4. Keluar");
            Console.WriteLine("\n");
            Console.Write("Pilih Mennu [1-4]: ");
                int menu = int.Parse(Console.ReadLine());

                if(menu==1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Tipe Karyawan : [1] Karyawan Tetap , [2] Karyawan Harian, [3] Sales");
                    Console.Write("Pilih Tipe Karyawan [1-3] : ");
                    int tipe = int.Parse(Console.ReadLine());            
                    if(tipe == 1)
                    {
                        Console.WriteLine("\n");
                        Console.Write("Nik : ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama : ");
                        string nama = Console.ReadLine();
                        Console.Write("Gaji Bulanan: ");
                        int gaji_bulanan = int.Parse(Console.ReadLine());
                      
                        string tipe_kary = "Karyawan Tetap";
                        tambah_kary_tetap(tipe_kary, nik, nama, gaji_bulanan);
                    }
                    if(tipe == 2)
                    {
                        Console.WriteLine("\n");
                        Console.Write("Nik : ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama : ");
                        string nama = Console.ReadLine();
                        Console.Write("Upah Perjam : ");
                        int upah_perjam = int.Parse(Console.ReadLine());
                        Console.Write("Jumlah Jam Kerja: ");
                        int jam_kerja = int.Parse(Console.ReadLine());

                      
                        string tipe_kary = "Karyawan Harian";
                        tambah_kary_harian(tipe_kary, nik, nama, upah_perjam, jam_kerja);
                    }

                    else if(tipe==3)
                    {
                        Console.WriteLine("\n");
                        Console.Write("Nik Karyawan : ");
                       string nik = Console.ReadLine();
                        Console.Write("Nama : ");
                       string nama = Console.ReadLine();
                        Console.Write("Jumlah Penjualan : ");
                       int jumlah_jual = int.Parse(Console.ReadLine());
                        Console.Write("Komisi: ");
                       int komisi= int.Parse(Console.ReadLine());
                        string tipe_kary = "Sales";
                        tambah_sales(tipe_kary, nik, nama, jumlah_jual, komisi);
                    }


                }
                else if(menu==2)
                {
                    hapus_karyawan();
                }
                else if(menu==3)
                {
                    
                    tampil_karyawan();
                }
                else if(menu==4)
                {
                    keluar = true;
                }
            }


            Console.ReadKey();
        }
    }
}
