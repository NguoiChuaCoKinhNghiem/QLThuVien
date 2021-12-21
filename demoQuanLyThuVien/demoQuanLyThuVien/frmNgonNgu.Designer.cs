namespace demoQuanLyThuVien
{
    partial class frmNgonNgu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTenNN = new System.Windows.Forms.TextBox();
            this.txtMaNN = new System.Windows.Forms.TextBox();
            this.lblNN = new System.Windows.Forms.Label();
            this.lblMaNN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoantat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenNN
            // 
            this.txtTenNN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNN.Location = new System.Drawing.Point(113, 146);
            this.txtTenNN.Name = "txtTenNN";
            this.txtTenNN.Size = new System.Drawing.Size(263, 25);
            this.txtTenNN.TabIndex = 36;
            // 
            // txtMaNN
            // 
            this.txtMaNN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNN.Location = new System.Drawing.Point(113, 93);
            this.txtMaNN.Name = "txtMaNN";
            this.txtMaNN.Size = new System.Drawing.Size(263, 25);
            this.txtMaNN.TabIndex = 35;
            // 
            // lblNN
            // 
            this.lblNN.AutoSize = true;
            this.lblNN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNN.Location = new System.Drawing.Point(17, 154);
            this.lblNN.Name = "lblNN";
            this.lblNN.Size = new System.Drawing.Size(77, 17);
            this.lblNN.TabIndex = 34;
            this.lblNN.Text = "Ngôn ngữ  :";
            // 
            // lblMaNN
            // 
            this.lblMaNN.AutoSize = true;
            this.lblMaNN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNN.Location = new System.Drawing.Point(17, 101);
            this.lblMaNN.Name = "lblMaNN";
            this.lblMaNN.Size = new System.Drawing.Size(93, 17);
            this.lblMaNN.TabIndex = 33;
            this.lblMaNN.Text = "Mã ngôn ngữ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 36);
            this.label1.TabIndex = 32;
            this.label1.Text = "THÔNG TIN NGÔN NGỮ";
            // 
            // btnHoantat
            // 
            this.btnHoantat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoantat.Location = new System.Drawing.Point(286, 198);
            this.btnHoantat.Name = "btnHoantat";
            this.btnHoantat.Size = new System.Drawing.Size(77, 29);
            this.btnHoantat.TabIndex = 42;
            this.btnHoantat.Text = "Hoàn tất";
            this.btnHoantat.UseVisualStyleBackColor = true;
            this.btnHoantat.Click += new System.EventHandler(this.btnHoantat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(220, 247);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 29);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(352, 247);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 29);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(89, 247);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 29);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 293);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 194);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(157, 198);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(77, 29);
            this.btnTroVe.TabIndex = 37;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click_1);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(394, 89);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 30);
            this.btnTimKiem.TabIndex = 43;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmNgonNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 497);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHoantat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.txtTenNN);
            this.Controls.Add(this.txtMaNN);
            this.Controls.Add(this.lblNN);
            this.Controls.Add(this.lblMaNN);
            this.Controls.Add(this.label1);
            this.Name = "frmNgonNgu";
            this.Text = "frmChiTietNgonNgu";
            this.Load += new System.EventHandler(this.frmChiTietNgonNgu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenNN;
        private System.Windows.Forms.TextBox txtMaNN;
        private System.Windows.Forms.Label lblNN;
        private System.Windows.Forms.Label lblMaNN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHoantat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnTimKiem;
    }
}