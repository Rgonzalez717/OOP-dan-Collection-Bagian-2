using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using oop_dan_collection.ClassInduk;

namespace oop_dan_collection.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public int GajiBulanan { get; set; }

        public override int Gaji() => GajiBulanan;
    }
}
