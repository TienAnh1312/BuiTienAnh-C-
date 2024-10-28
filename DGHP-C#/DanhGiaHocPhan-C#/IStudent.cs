using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhGiaHocPhan_C_
{
    internal interface IStudent
    {
        int StudID { get; set; }

        string StudName { get; set; }

        string StudGender { get; set; }

        int StudAge { get; set; }

        string StudClass { get; set; }

        float StudAvgMark { get; }

        // in thông tin 
        void Print();
    }
}
