using De01.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01.BUS.Services
{
    public class LopService
    {
        private QuanLySvContext context = new QuanLySvContext();
        // get all
        public List<Lop> getAll()
        {
            return context.Lops.ToList();
        }
        // find by name
        public List<Lop> findByName(string name)
        {
            return context.Lops.Where(x=>x.TenLop.Equals(name)).ToList();
        }
    }
}
