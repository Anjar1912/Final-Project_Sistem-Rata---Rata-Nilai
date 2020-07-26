using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasUAS.KelasAnak;
using TugasUAS.KelasInduk;

namespace TugasUAS
{
    class Program
    {
        static List<DataSiswa> DaftarSiswa = new List<DataSiswa>();
        static void Main(string[] args)
        {
            int pilA;
            do
            {
                Console.WriteLine("=== MENU PROGRAM DATA SISWA ===");
                Console.WriteLine("1. Inputkan data \n2. Tampilkan Data \n3. Hapus Data \n4. Keluar");
                Console.Write("Masukkan pilihan menu : "); pilA = int.Parse(Console.ReadLine());
                if (pilA == 1)
                {
                    int pilB;
                    Console.WriteLine("== KELAS ==");
                    Console.WriteLine("1. IPA \n2. IPS");
                    Console.Write("Masukkan pilihan kelas : "); pilB = int.Parse(Console.ReadLine());
                    if (pilB == 1)
                    {
                        Console.Write("Nama : "); string Nama = Console.ReadLine();
                        Console.Write("NIS : "); string Nis = Console.ReadLine();
                        Console.Write("Kelas : "); string Kelas = Console.ReadLine();
                        Console.WriteLine("Masukkan Nilai");
                        Console.Write("Matematika : "); double Matematika = double.Parse(Console.ReadLine());
                        Console.Write("Biologi : "); double Biolgi = double.Parse(Console.ReadLine());
                        Console.Write("Fsiska : "); double Fisika = double.Parse(Console.ReadLine());
                        Console.Write("Kimia : "); double Kimia = double.Parse(Console.ReadLine());
                        TambahIPA(Nama, Nis, Kelas, Matematika, Biolgi, Fisika, Kimia);

                    }
                    else if (pilB == 2)
                    {
                        Console.Write("Nama : "); string Nama = Console.ReadLine();
                        Console.Write("NIS : "); string Nis = Console.ReadLine();
                        Console.Write("Kelas : "); string Kelas = Console.ReadLine();
                        Console.WriteLine("Masukkan Nilai");
                        Console.Write("Matematika : "); double Matematika = double.Parse(Console.ReadLine());
                        Console.Write("Ekonomi : "); double Ekonomi = double.Parse(Console.ReadLine());
                        Console.Write("Sejarah : "); double Sejarah = double.Parse(Console.ReadLine());
                        Console.Write("Geografi : "); double Geografi = double.Parse(Console.ReadLine());
                        TambahIPS(Nama, Nis, Kelas, Matematika, Ekonomi, Sejarah, Geografi);
                    }
                    else
                    {
                        Console.WriteLine("Pilihan Tidak ada...");
                    }
                }
                else if (pilA == 2)
                {
                    TampilDataSiswa();
                }
                else if (pilA == 3)
                {
                    HapusDataSiswa();
                }
                else
                {
                    Console.WriteLine("Pilihan Tidak ada...");
                }
            }
            while (pilA != 4);
            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadKey();

        }
        static void TambahIPA(string nama, string nis, string kelas, double matematika, double biologi, double fisika, double kimia)
        {
            DaftarSiswa.Add(new KelasIPA
            {
                Nama = nama,
                Nis = nis,
                Kelas = kelas,
                NMatematika = matematika,
                NBiologi = biologi,
                NFisika = fisika,
                NKimia = kimia
            });
        }
        static void TambahIPS(String nama, string nis, string kelas, double matematika, double ekonomi, double sejarah, double geografi)
        {
            DaftarSiswa.Add(new KelasIPS
            {
                Nama = nama,
                Nis = nis,
                Kelas = kelas,
                NMatematika = matematika,
                NEkonomi = ekonomi,
                NSejarah = sejarah,
                NGeografi = geografi
            });
        }
        static void TampilDataSiswa()
        {
            int urut = 1;
            foreach (DataSiswa DataSiswa in DaftarSiswa)
            {
                Console.WriteLine("|{0}. |Nama : {1}|NIS : {2} | Kelas : {3} |Rataan Nilai : {4} |",
                    urut, DataSiswa.Nama, DataSiswa.Nis, DataSiswa.Kelas, DataSiswa.Nilai());
                urut++;
            }
        }
        static void HapusDataSiswa()
        {
            string kodehps;
            int hps = -1, n = -1;

            Console.WriteLine("Hapus Data");
            Console.Write("NIS Siswa : "); kodehps = Console.ReadLine();

            foreach (DataSiswa DataSiswa in DaftarSiswa)
            {
                n++;
                if (DataSiswa.Nis == kodehps)
                {
                    hps = n;
                }
            }
            if (hps != -1)
            {
                DaftarSiswa.RemoveAt(hps);
            }
            else
            {
                Console.WriteLine("\nKode Produk Tidak Ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

    }
}
