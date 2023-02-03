﻿using System;
using System.Collections.Generic;

namespace CSharp5.Models
{
    public class GiamGiaHD
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ChuongTrinh { get; set; }
        public double GiaTri { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public bool KhongGioiHan { get; set; }
        public int SoLuong { get; set; }

        public List<HoaDon> hoaDons { get; set; }
    }
}
