using System;
using System.Collections.Generic;

namespace De01.DAL.Models;

public partial class SinhVien
{
    public string MaSv { get; set; } = null!;

    public string HotenSv { get; set; } = null!;

    public string? NgaySinh { get; set; }

    public string MaLop { get; set; } = null!;

    public virtual Lop MaLopNavigation { get; set; } = null!;
}
