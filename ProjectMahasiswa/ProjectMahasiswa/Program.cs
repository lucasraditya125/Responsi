using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";



            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampil Mahasiswa");
            Console.WriteLine("4. Keluar");
            Console.Write("\nNomor Menu [1..4]: ");
            int nomorMenu = Convert.ToInt32(Console.ReadLine());
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            int n, baris, data;
            string[] nim = new string[25];
            string[] nama = new string[25];
            string[] jeniskelamin = new string[25];
            string[] ipk = new string[25];

            baris = n + 1;
            
            
            Console.Write("NIM: ");
            nim[n] = Convert.ToString(Console.ReadLine());
            Console.Write("Nama: ");
            nama[n] = Convert.ToString(Console.ReadLine());
            Console.Write("Jenis Kelamin: ");
            jeniskelamin[n] = Convert.ToString(Console.ReadLine());
            Console.Write("IPK: ");
            ipk[n] = Convert.ToString(Console.ReadLine());
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            int n, baris, data;
            string[] nim = new string[25];
            string[] nama = new string[25];
            string[] jeniskelamin = new string[25];
            string[] ipk = new string[25];

            baris = n + 1;
            Console.SetCursorPosition(1, 5); Console.Write("no");
            Console.SetCursorPosition(2, 5); Console.Write("NIM: ");
            Console.SetCursorPosition(3, 5); Console.Write("Nama: ");
            Console.SetCursorPosition(4, 5); Console.Write("Jenis Kelamin: ");
            Console.SetCursorPosition(5, 5); Console.Write("IPK: ");
            for (n = 0; n < data; n++)
            {
                baris = 7 + n;
                Console.SetCursorPosition(1, baris); Console.Write(n + 1);
                Console.SetCursorPosition(2, baris); Console.Write(nim[n]);
                Console.SetCursorPosition(3, baris); Console.Write(nama[n]);
                Console.SetCursorPosition(4, baris); Console.Write(jeniskelamin[n]);
                Console.SetCursorPosition(5, baris); Console.Write(ipk[n]);
                Console.WriteLine("\nTekan enter untuk kembali ke menu");

            }
            
            Console.ReadKey();
        }
    }
}
