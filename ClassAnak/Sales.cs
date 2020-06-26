using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_dan_collection.ClassInduk;

namespace oop_dan_collection.ClassAnak
{
    class Sales : Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int Komisi { get; set; }

        public override int Gaji() => JumlahPenjualan * Komisi;
    }
}
