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
    public partial class frmNhaXuatBan : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }

        private void frmNhaXuatBan_Load(object sender, EventArgs e)
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
            listView1.Columns.Add("Tên nhà xuất bản", 150);
            listView1.Columns.Add("Địa chỉ", 300);
            listView1.Columns.Add("SĐT", 100);
            foreach (NhaXuatBan nxb in db.NhaXuatBan.ToList())
            {
                ListViewItem li = listView1.Items.Add(nxb.tenxb);
                li.SubItems.Add(nxb.diachi);
                li.SubItems.Add(nxb.sdt.ToString());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            NhaXuatBan nxb = db.NhaXuatBan.Find(txtTimKiem.Text);
            if (nxb != null)
            {
                listView1.Items.Clear();
                ListViewItem li = listView1.Items.Add(nxb.tenxb);
                li.SubItems.Add(nxb.diachi);
                li.SubItems.Add(nxb.sdt.ToString());

            }
            else
            {
                MessageBox.Show("Không tìn thấy thông tin nhà xuất bản!!!!!");
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
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
            NhaXuatBan nxb = db.NhaXuatBan.Find(txtTimKiem.Text);
            if(nxb!= null)
            {
                MessageBox.Show("Không thể thêm mới nhà xuất bản do nhà xuất bản đã tồn tại!!!!!!");
            }
            else
            {
                nxb = new NhaXuatBan();
                nxb.tenxb = txtTimKiem.Text;
                nxb.diachi = txtDiaChi.Text;
                nxb.sdt = int.Parse(txtSDT.Text);
                db.NhaXuatBan.Add(nxb);
                db.SaveChanges();
                hienthi();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaXuatBan nxb = db.NhaXuatBan.Find(txtTimKiem.Text);
            if (nxb == null)
            {
                MessageBox.Show("Ngôn ngữ chưa tồn tại nên không thể xóa!!");
            }
            nxb.diachi = txtDiaChi.Text;
            nxb.sdt = int.Parse(txtSDT.Text);
            db.SaveChanges();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            foreach (ListViewItem li in listView1.SelectedItems)
            {
                kq = true;
                NhaXuatBan nxb = db.NhaXuatBan.Find(li.SubItems[0].Text);
                if (nxb != null)
                {
                    if (nxb.Sach.Count == 0)
                        db.NhaXuatBan.Remove(nxb);
                    else
                        MessageBox.Show("Không thể xóa được!!!!!!");
                }
                db.SaveChanges();
            }
            if (kq)
                hienthi();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem li in listView1.SelectedItems)
            {
                txtTimKiem.Text = li.SubItems[0].Text;
                txtDiaChi.Text = li.SubItems[1].Text;
                txtSDT.Text = li.SubItems[2].Text;
            }
        }
    }
}
