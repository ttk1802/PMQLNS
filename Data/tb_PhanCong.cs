//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_PhanCong
    {
        public int MaPC { get; set; }
        public string TenPC { get; set; }
        public int MaPB { get; set; }
        public int MaCV { get; set; }
        public string MaNV { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual tb_ChucVu tb_ChucVu { get; set; }
        public virtual tb_PhongBan tb_PhongBan { get; set; }
    }
}
