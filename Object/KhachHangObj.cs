using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH14;
using QLBH14.Database;
using QLBH14.Logic;


namespace QLBH14.Object
{
    class KhachHangObj
    {
        string ma, ten, diachi, sdt;

        public string MaKH
        {
            get { return ma; }
            set { ma = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string TenKH
        {
            get { return ten; }
            set { ten = value; }
        }

        

        public KhachHangObj()
        {

        }
        public KhachHangObj(string ma , string ten , string diachi , string sdt)
        {
            this.ma = ma;
            this.ten = ten;
            this.diachi = diachi;
            this.sdt = sdt;

        }
    }
}
