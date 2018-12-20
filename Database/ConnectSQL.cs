using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBH14.Database
{
    class ConnectSQL
    {

        #region Availible
        private SqlConnection conn;
        private SqlCommand _cmd;
        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        public SqlConnection Connection { get { return conn; } }
        private string error;
        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        string strCon;
        #endregion

        #region Contructor
        public ConnectSQL()
        {
            strCon = @"Data Source=Phis;Initial Catalog=QLBH;Integrated Security=True";
            conn = new SqlConnection(strCon);
        }
        #endregion
        #region Methods
        public bool OpenConn()
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;

            }
            return true;
        }
        #endregion

    }
}
