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
    public partial class frmNgonNgu : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        public frmNgonNgu()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLSach ql = new frmQLSach();
            ql.ShowDialog();
        }

        private void frmChiTietNgonNgu_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Mã ngôn ngữ",100);
            listView1.Columns.Add("Tên ngôn ngữ", 150);
            foreach(NgonNgu nn in db.NgonNgu.ToList())
            {
                ListViewItem li = listView1.Items.Add(nn.mann);
                li.SubItems.Add(nn.tennn);
            }
        }

        private void btnTroVe_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmQLSach ql = new frmQLSach();
            ql.ShowDialog();
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NgonNgu nn = new NgonNgu();
            nn.mann = txtMaNN.Text;
            nn.tennn = txtTenNN.Text;
            db.NgonNgu.Add(nn);
            db.SaveChanges();
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NgonNgu nn = db.NgonNgu.Find(txtMaNN.Text);
            if (nn == null)
            {
                MessageBox.Show("Ngôn ngữ chưa tồn tại nên không thể xóa!!");
            }
            nn.tennn = txtTenNN.Text;
            db.SaveChanges();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            foreach (ListViewItem li in listView1.SelectedItems)
            {
                kq = true;
                NgonNgu nn = db.NgonNgu.Find(li.SubItems[0].Text);
                if (nn != null)
                {
                    if (nn.Sach.Count == 0)
                        db.NgonNgu.Remove(nn);
                    else
                        MessageBox.Show("Không thể xóa!!!!!!!");
                }
                db.SaveChanges();
            }
            if (kq)
                hienthi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            NgonNgu nn = db.NgonNgu.Find(txtTenNN.Text);
            if (nn != null)
            {
                listView1.Items.Clear();
                ListViewItem li = listView1.Items.Add(nn.mann);
                li.SubItems.Add(nn.tennn);

            }
            else
            {
                MessageBox.Show("Không tìn thấy thông tin ngôn ngữ!!!!!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem li in listView1.SelectedItems)
            {
                txtMaNN.Text = li.SubItems[0].Text;
                txtTenNN.Text = li.SubItems[1].Text;
            }
        }
    }
}
