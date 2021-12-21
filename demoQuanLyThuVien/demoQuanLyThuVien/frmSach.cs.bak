using demoQuanLyThuVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoQuanLyThuVien
{
    public partial class frmSach : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        ThanhVien tv;
        PhieuMuonSach pm;
        public frmSach()
        {
            InitializeComponent();
        }
		public frmSach(ThanhVien tv)
        {
            this.tv = tv;
            InitializeComponent();
        }
        public frmSach(PhieuMuonSach pm, ThanhVien tv)
        {
            this.tv = tv;
            this.pm = pm;
            InitializeComponent();
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLSach ql = new frmQLSach();
            ql.ShowDialog();
        }
		 private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChiTietSach cts = new frmChiTietSach();
            cts.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem li in listView1.SelectedItems)
            {
                Sach s = db.Sach.Find(li.SubItems[0].Text);
                frmChiTietSach sach = new frmChiTietSach(s);
                this.Hide();
                sach.ShowDialog();
            }

        }
        
    }
}
