using De01.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01.BUS.Services
{
    public class SinhVienService
    {
        private QuanLySvContext context = new QuanLySvContext();
        // get all
        public List<SinhVien> getAll()
        {
            return context.SinhViens.ToList();
        }
        // add sinh vien
        public void add(SinhVien sinhVien)
        {
            context.SinhViens.Add(sinhVien);
            context.SaveChanges();
        }
        // delete sinhvien
        public void delete(string masv)
        {
            SinhVien sinhVien = context.SinhViens.Where(x=>x.MaSv.Equals(masv)).FirstOrDefault();
            context.SinhViens.Remove(sinhVien);
            context.SaveChanges();
        }
        // get by id
        public List<SinhVien> getById(string id)
        {
            return context.SinhViens.Where(x=>x.MaSv.Equals(id)).ToList();
        }
    }
}
