using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHUNG_THOM.Model
{
    public class StudentModel
    {
        public int MASV { get; set; }
        public string HO { get; set; }
        public string TEN { get; set; }
        public string PHAI { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string NOISINH { get; set; }
        public string DIACHI { get; set; }
        public string GHICHU { get; set; }
        public bool NGHIHOC { get; set; }
        public StudentModel()
        {

        }
    }
}
