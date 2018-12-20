using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLBH14.Logic;
using QLBH14.Object;

namespace QLBH14.Control
{
    class KhachHangctrl
    {
        KhachHanglgc khlgc = new KhachHanglgc();
        public DataTable GetData()
        {
            return khlgc.GetData();
        }
        public bool AddData(KhachHangObj khObj)
        {
            return khlgc.AddData(khObj);
        }
        public bool UpData (KhachHangObj khObj)
        {
            return UpData(khObj);
        }
        public bool DelData(string ma)
        {
            return khlgc.DelData(ma);
        }

    }
}
