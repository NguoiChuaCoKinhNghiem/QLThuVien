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
    public partial class frmPhieuMuonSach : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        ThanhVien tv;
        Sach s;
        public frmPhieuMuonSach()
        {
            InitializeComponent();
        }
         private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            PhieuMuonSach pm = db.PhieuMuonSach.Find(txtTimKiem.Text);
            if(pm!= null)
            {
                listView1.Items.Clear();
                ListViewItem li = listView1.Items.Add(pm.maphieumuon);
                li.SubItems.Add(pm.mathanhvien);
                li.SubItems.Add(pm.masach);
                li.SubItems.Add(pm.ngaymuon.Value.ToString("dd/MM/yyyy"));
                li.SubItems.Add(pm.ngayhentra.Value.ToString("dd/MM/yyyy"));
            }
        }
		
    }
}
