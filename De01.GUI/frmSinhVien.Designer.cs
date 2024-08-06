namespace De01.GUI
{
    partial class frmSinhVien
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
            groupBox1 = new GroupBox();
            cboLop = new ComboBox();
            dtNgaySinh = new DateTimePicker();
            txtHotenSV = new TextBox();
            txtMaSV = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btThoat = new Button();
            btKhong = new Button();
            btLuu = new Button();
            btSua = new Button();
            btXoa = new Button();
            btThem = new Button();
            btn_find = new Button();
            textBox1 = new TextBox();
            lvSinhVien = new ListView();
            col_mssv = new ColumnHeader();
            col_fullname = new ColumnHeader();
            col_ngaysinh = new ColumnHeader();
            col_lop = new ColumnHeader();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboLop);
            groupBox1.Controls.Add(dtNgaySinh);
            groupBox1.Controls.Add(txtHotenSV);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(82, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(424, 118);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(225, 28);
            cboLop.TabIndex = 7;
            // 
            // dtNgaySinh
            // 
            dtNgaySinh.Location = new Point(142, 121);
            dtNgaySinh.Name = "dtNgaySinh";
            dtNgaySinh.Size = new Size(196, 27);
            dtNgaySinh.TabIndex = 6;
            // 
            // txtHotenSV
            // 
            txtHotenSV.Location = new Point(424, 40);
            txtHotenSV.Name = "txtHotenSV";
            txtHotenSV.Size = new Size(225, 27);
            txtHotenSV.TabIndex = 5;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(142, 40);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(196, 27);
            txtMaSV.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 121);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Lớp Học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 43);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 121);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày Sinh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 43);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btThoat);
            panel1.Controls.Add(btKhong);
            panel1.Controls.Add(btLuu);
            panel1.Controls.Add(btSua);
            panel1.Controls.Add(btXoa);
            panel1.Controls.Add(btThem);
            panel1.Location = new Point(303, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 39);
            panel1.TabIndex = 1;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(392, 4);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(71, 29);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btKhong
            // 
            btKhong.BackColor = SystemColors.ActiveBorder;
            btKhong.Enabled = false;
            btKhong.ForeColor = SystemColors.ControlDark;
            btKhong.Location = new Point(316, 4);
            btKhong.Name = "btKhong";
            btKhong.Size = new Size(70, 28);
            btKhong.TabIndex = 4;
            btKhong.Text = "K.Lưu";
            btKhong.UseVisualStyleBackColor = false;
            // 
            // btLuu
            // 
            btLuu.BackColor = SystemColors.ActiveBorder;
            btLuu.Enabled = false;
            btLuu.ForeColor = SystemColors.ControlDark;
            btLuu.Location = new Point(236, 4);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(74, 29);
            btLuu.TabIndex = 3;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = false;
            // 
            // btSua
            // 
            btSua.Location = new Point(160, 3);
            btSua.Name = "btSua";
            btSua.Size = new Size(70, 29);
            btSua.TabIndex = 2;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(85, 3);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(69, 29);
            btXoa.TabIndex = 1;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btThem
            // 
            btThem.Location = new Point(3, 3);
            btThem.Name = "btThem";
            btThem.Size = new Size(76, 29);
            btThem.TabIndex = 0;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btn_find
            // 
            btn_find.Location = new Point(217, 221);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(80, 39);
            btn_find.TabIndex = 2;
            btn_find.Text = "Tìm";
            btn_find.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 27);
            textBox1.TabIndex = 3;
            // 
            // lvSinhVien
            // 
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { col_mssv, col_fullname, col_ngaysinh, col_lop });
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.Location = new Point(82, 281);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(687, 216);
            lvSinhVien.TabIndex = 4;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.ItemSelectionChanged += lvSinhVien_ItemSelectionChanged;
            // 
            // col_mssv
            // 
            col_mssv.Text = "Mã SV";
            // 
            // col_fullname
            // 
            col_fullname.Text = "Họ và Tên";
            // 
            // col_ngaysinh
            // 
            col_ngaysinh.Text = "Ngày Sinh";
            // 
            // col_lop
            // 
            col_lop.Text = "Lớp";
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 509);
            Controls.Add(lvSinhVien);
            Controls.Add(textBox1);
            Controls.Add(btn_find);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "frmSinhVien";
            Text = "Danh Sách Sinh Viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboLop;
        private DateTimePicker dtNgaySinh;
        private TextBox txtHotenSV;
        private TextBox txtMaSV;
        private Panel panel1;
        private Button btn_find;
        private TextBox textBox1;
        private Button btXoa;
        private Button btThem;
        private Button btThoat;
        private Button btKhong;
        private Button btLuu;
        private Button btSua;
        private ListView lvSinhVien;
        private ColumnHeader col_mssv;
        private ColumnHeader col_fullname;
        private ColumnHeader col_ngaysinh;
        private ColumnHeader col_lop;
    }
}