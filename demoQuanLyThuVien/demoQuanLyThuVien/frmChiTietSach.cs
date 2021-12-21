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
    public partial class frmChiTietSach : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        public frmChiTietSach()
        {
            InitializeComponent();
            KhoiTao();
        }

        
    }
}
