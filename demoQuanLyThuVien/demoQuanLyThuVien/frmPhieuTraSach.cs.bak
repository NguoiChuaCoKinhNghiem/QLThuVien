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
    public partial class frmPhieuTraSach : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        public frmPhieuTraSach()
        {
            InitializeComponent();
        }
        private void frmPhieuTraSach_Load(object sender, EventArgs e)
        {
            hienthi();
            khoitao();
        }
        public void hienthi()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Mã phiếu trả",80);
            listView1.Columns.Add("Mã phiếu mượn", 100);
            listView1.Columns.Add("Ngày trả", 120);
            listView1.Columns.Add("Tình trạng", 120);
            listView1.Columns.Add("Phí phạt", 120);
            foreach(PhieuTraSach pt in db.PhieuTraSach.ToList())
            {
                ListViewItem li = listView1.Items.Add(pt.maphieutra);
                li.SubItems.Add(pt.maphieumuon);
                li.SubItems.Add(pt.ngaytra.Value.ToString("dd/MM/yyyy"));
                li.SubItems.Add(pt.tinhtrang);
                li.SubItems.Add(pt.tienphat.ToString());

            }
        }
        public void khoitao()
        {
            cboTT.Items.Clear();
            cboTT.Items.Add("Trả đúng hạn!!!!!!");
            cboTT.Items.Add("Trả trễ hạn!!!!!!!!!!!!");
            cboTT.SelectedIndex = 0;
        }
    }
}
