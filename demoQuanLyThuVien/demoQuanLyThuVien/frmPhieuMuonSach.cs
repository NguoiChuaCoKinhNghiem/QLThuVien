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
        
    }
}
