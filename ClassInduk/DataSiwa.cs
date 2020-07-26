using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasUAS.KelasInduk
{
    public abstract class DataSiswa
    {
        public string Nama { get; set; }
        public string Nis { get; set; }
        public string Kelas { get; set; }
        public abstract double Nilai();
    }
}

