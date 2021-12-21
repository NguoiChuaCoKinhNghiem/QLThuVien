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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            txtTentt.Text = "Ngô Thùy Thương";
            txtDate.Text = DateTime.Today.Date.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm");

        }

        
    }
}
