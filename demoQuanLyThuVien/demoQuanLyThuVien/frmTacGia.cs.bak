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
    public partial class frmTacGia : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
        public frmTacGia()
        {
            InitializeComponent();
        }
        public void hienthi()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Mã tác giả", 100);
            listView1.Columns.Add("Tên tác giả", 200);
            foreach(TacGia tg  in db.TacGia.ToList())
            {
                ListViewItem lv = listView1.Items.Add(tg.matg);
                lv.SubItems.Add(tg.tentg);

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem li in listView1.SelectedItems)
            {
                txtTimKiem.Text = li.SubItems[0].Text;
                txtTenTG.Text = li.SubItems[1].Text;
            }

        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLSach ql = new frmQLSach();
            ql.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TacGia tg = db.TacGia.Find(txtTimKiem.Text);
            if (tg != null)
            {
                listView1.Items.Clear();
                ListViewItem li = listView1.Items.Add(tg.matg);
                li.SubItems.Add(tg.tentg);
            }
            else
            {
                MessageBox.Show("Không tìn thấy thông tin tác giả!!!!");
            }
        }

        private void btnHoantat_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TacGia tg = db.TacGia.Find(txtTimKiem.Text);
            if (tg != null)
            {
                MessageBox.Show("Tác giả đã tồn tại, không thể thêm mới!");
            }
            else
            {
                tg = new TacGia();
                tg.matg = txtTimKiem.Text;
                tg.tentg = txtTenTG.Text;
                db.TacGia.Add(tg);
                db.SaveChanges();
                hienthi();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TacGia tg = db.TacGia.Find(txtTimKiem.Text);
            if (tg == null)
            {
                MessageBox.Show("Tác giả chưa tồn tại nên không thể xóa!!");
            }
            tg.tentg = txtTenTG.Text;
            db.SaveChanges();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            foreach (ListViewItem li in listView1.SelectedItems)
            {
                kq = true;
                TacGia tg = db.TacGia.Find(li.SubItems[0].Text);
                if(tg!=null)
                {
                    if (tg.Sach.Count == 0)
                        db.TacGia.Remove(tg);
                    else
                        MessageBox.Show("không thể xóa được!!!!!!");
                }
                db.SaveChanges();
            }
            if (kq)
            {
                hienthi();
            }
        }
        
    }
}
