using Kiemtra.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiemtra
{
    public partial class frmQuanLyDanhBa : Form
    {
        private object listDanhba;
        private object listNhom;

        public frmQuanLyDanhBa()
        {
            InitializeComponent();
            listNhom = Nhom.getfromfile();
            dgvNhom.AutoGenerateColumns = false;
            bdsNhom.DataSource = listNhom;
            dgvNhom.DataSource = bdsNhom;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnThemNhom_Click(object sender, EventArgs e)
        {

        }

        private void DgvNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDanhba.AutoGenerateColumns = false;
            var temp = (Nhom)bdsNhom.Current;
            listDanhba = DanhBa.getfromfile(temp.TenNhom);
            bdsDanhba.DataSource = listDanhba;
            dgvDanhba.DataSource = bdsDanhba;
        }

        private void DgvNhom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
