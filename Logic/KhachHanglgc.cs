using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLBH14.Database;
using QLBH14.Object;
using QLBH14.View;



namespace QLBH14.Logic
{
    class KhachHanglgc
    {

        ConnectSQL con = new ConnectSQL();
        SqlCommand cmd = new SqlCommand();
       

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * From tb_KhacHang";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.Fill(dt);
                con.CloseConn();

            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return dt;
           
        }

        public bool AddData(KhachHangObj khObj)

        {
            cmd.CommandText = "Insert into tb_KhachHang VALUES('"+khObj.MaKH+"','"+khObj.TenKH+"','"+khObj.DiaChi+"','"+khObj.SDT+"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();

            }
            catch(Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return false;
        }

        public bool UpData(KhachHangObj khObj)
        {
            cmd.CommandText = "Update tb_KhachHang set TenKH='" + khObj.TenKH + "',DiaChi='" + khObj.DiaChi + "',SDT='" + khObj.SDT + "',where MaKH='"+khObj.MaKH+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return false;
        }

        public bool DelData(string ma )
        {
            cmd.CommandText = "Delete tb_KhachHang Where MaKH= '" +ma+ "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();

            }
            return false;
        }


        
        
    }
}
