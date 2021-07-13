using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa
    {
        public string nim;
        public string nama;
        public string jeniskelamin;
        public string ipk;

        public void tampilkan()
        {
            Console.WriteLine("NIM: " + nim);
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Jenis Kelamin: " + jeniskelamin);
            Console.WriteLine("IPK: " + ipk);
        }
        // PERINTAH: lengkapi property class mahasiswa, sesuai petunjuk soal
    }
}
