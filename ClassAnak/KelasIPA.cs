using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasUAS.KelasInduk;

namespace TugasUAS.KelasAnak
{
    public class KelasIPA : DataSiswa
    {
        public double NMatematika { get; internal set; }
        public double NBiologi { get; internal set; }
        public double NFisika { get; internal set; }
        public double NKimia { get; internal set; }
        public override double Nilai()
        {
            return (NMatematika + NBiologi + NFisika + NKimia) / 4;
        }
    }
}
