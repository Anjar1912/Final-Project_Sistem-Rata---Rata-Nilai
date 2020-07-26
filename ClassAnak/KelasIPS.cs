using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasUAS.KelasInduk;

namespace TugasUAS.KelasAnak
{
    public class KelasIPS : DataSiswa
    {
        public double NMatematika { get; set; }
        public double NEkonomi { get; set; }
        public double NSejarah { get; set; }
        public double NGeografi { get; set; }

        public override double Nilai()
        {
            return (NMatematika + NEkonomi + NSejarah + NGeografi) / 4;
        }
    }
}
