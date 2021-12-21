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
    public partial class frmThanhVien : Form
    {
        Model.ModelThuVien db = new Model.ModelThuVien();
       
        public frmThanhVien()
        {
            InitializeComponent();
        }
         private void frmThanhVien_Load(object sender, EventArgs e)
        {
            hienthi();
            
        }
        public void hienthi()
        {
            lvThanhVien.View = View.Details;
            lvThanhVien.GridLines = true;
            lvThanhVien.FullRowSelect = true;
            lvThanhVien.Items.Clear();
            lvThanhVien.Columns.Clear();
            lvThanhVien.Columns.Add("Mã số", 80);
            lvThanhVien.Columns.Add("Họ tên", 150);
            lvThanhVien.Columns.Add("Giới tính", 80);
            lvThanhVien.Columns.Add("Địa chỉ", 200);
            lvThanhVien.Columns.Add("SĐT", 100);
            lvThanhVien.Columns.Add("CMND", 100);
            lvThanhVien.Columns.Add("Email", 200);
            foreach(ThanhVien tv in db.ThanhVien.ToList())
            {
                ListViewItem li = lvThanhVien.Items.Add(tv.matv);
                li.SubItems.Add(tv.hoten);
                if (tv.gioitinh == true)
                {
                    li.SubItems.Add("Nam");
                }
                else
                    li.SubItems.Add("Nữ");
                li.SubItems.Add(tv.diachi);
                li.SubItems.Add(tv.sdt);
                li.SubItems.Add(tv.smnd);
                li.SubItems.Add(tv.mail);
            }
        }
        
        
    }
}
