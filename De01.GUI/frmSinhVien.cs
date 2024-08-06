using De01.BUS.Services;
using De01.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace De01.GUI
{
    public partial class frmSinhVien : Form
    {
        private readonly LopService lopService = new LopService();
        private readonly SinhVienService sinhVienService = new SinhVienService();
        private int index = -1;
        private string masv = null;
        public frmSinhVien()
        {
            InitializeComponent();
            // add lop to cboLop
            List<Lop> lops = lopService.getAll();
            foreach (Lop lop in lops)
            {
                cboLop.Items.Add(lop.TenLop);
            }
            if (lops.Count > 0)
            {
                cboLop.Text = lops[0].TenLop;
            }
            List<SinhVien> sinhViens = sinhVienService.getAll();

            ListViewItem listView;
            foreach (SinhVien sinhVien in sinhViens)
            {

                listView = new ListViewItem(sinhVien.MaSv);
                listView.SubItems.Add(sinhVien.HotenSv);
                listView.SubItems.Add(sinhVien.NgaySinh.ToString());
                foreach (Lop lop in lops)
                {
                    if (lop.MaLop.Equals(sinhVien.MaLop))
                    {
                        listView.SubItems.Add(lop.TenLop);
                        break;
                    }
                }
                lvSinhVien.Items.Add(listView);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == null || txtHotenSV.Text == null)
            {
                MessageBox.Show("Vui lòng nhập đủ trường dữ liệu!", "Thông Báo");
            }
            else
            {
                Lop? lop = lopService.findByName(cboLop.Text).FirstOrDefault();
                SinhVien sinhVien = new SinhVien()
                {
                    MaSv = txtMaSV.Text,
                    HotenSv = txtHotenSV.Text,
                    NgaySinh = dtNgaySinh.Text,
                    MaLop = lop.MaLop
                };
                sinhVienService.add(sinhVien);
                ListViewItem listView = new ListViewItem(sinhVien.MaSv);
                listView.SubItems.Add(sinhVien.HotenSv);
                listView.SubItems.Add(sinhVien.NgaySinh.ToString());
                List<Lop> lops = lopService.getAll();
                foreach (Lop lop1 in lops)
                {
                    if (lop1.MaLop.Equals(sinhVien.MaLop))
                    {
                        listView.SubItems.Add(lop1.TenLop);
                        break;
                    }
                }
                lvSinhVien.Items.Add(listView);
            }
        }

        private void lvSinhVien_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            ListViewItem item = lvSinhVien.Items[e.ItemIndex];
            txtMaSV.Text = item.Text;
            txtHotenSV.Text = item.SubItems[1].Text;
            List<Lop> lops = lopService.getAll();
            foreach (Lop lop1 in lops)
            {
                if (lop1.TenLop.Equals(item.SubItems[3].Text))
                {
                    cboLop.Text = lop1.TenLop;
                    break;
                }
            }
            index = e.ItemIndex;
            masv = item.Text;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn đóng form không!", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn Xoa không!", "Thông Báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (index != -1)
                {
                    lvSinhVien.Items.RemoveAt(index);
                    sinhVienService.delete(masv);
                }
            }
            index = -1;
            masv = null;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Lop? lop = lopService.findByName(cboLop.Text).FirstOrDefault();
            SinhVien sinhVien = new SinhVien()
            {
                MaSv = txtMaSV.Text,
                HotenSv = txtHotenSV.Text,
                NgaySinh = dtNgaySinh.Text,
                MaLop = lop.MaLop
            };
            sinhVienService.edit(sinhVien);
            lvSinhVien.Items.Clear();
            List<SinhVien> sinhViens = sinhVienService.getAll();
            List<Lop> lops = lopService.getAll();
            ListViewItem listView;
            foreach (SinhVien sinhVien1 in sinhViens)
            {

                listView = new ListViewItem(sinhVien1.MaSv);
                listView.SubItems.Add(sinhVien1.HotenSv);
                listView.SubItems.Add(sinhVien1.NgaySinh.ToString());
                foreach (Lop lop1 in lops)
                {
                    if (lop1.MaLop.Equals(sinhVien1.MaLop))
                    {
                        listView.SubItems.Add(lop1.TenLop);
                        break;
                    }
                }
                lvSinhVien.Items.Add(listView);
            }
        }
    }
}
