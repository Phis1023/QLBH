using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH14.Control;
using QLBH14.Object;
using QLBH14.Logic;
using QLBH14.Database;
using QLBH14.QLBHDataSetTableAdapters;

namespace QLBH14.View
{
    public partial class KhachHang : Form
    {
        KhachHanglgc khlg = new KhachHanglgc();
        KhachHangObj khObj;


        public KhachHang()
        {
            InitializeComponent();
        }
        void Enable(bool Edit)
        {
            btnThem.Enabled = !Edit;
            btnSua.Enabled = !Edit;
            btnXoa.Enabled = !Edit;
            btnLuu.Enabled = !Edit;
            btnBoQua.Enabled = !Edit;
            btnThoat.Enabled = !Edit;
            txtMaKH.Enabled = Edit;
            txtTenKH.Enabled = Edit;
            txtDiaChi.Enabled = Edit;
            txtSDT.Enabled = Edit;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            Enable(false);
            dataGridView1.DataSource = khlg.GetData();

            
            
        }
       
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txtMaKH.Text = selectedRow.Cells[0].Value.ToString();
            txtTenKH.Text = selectedRow.Cells[1].Value.ToString();
            txtDiaChi.Text = selectedRow.Cells[2].Value.ToString();
            txtSDT.Text = selectedRow.Cells[3].Value.ToString();

        }

        private void qLBHDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
