//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAIKHOAN()
        {
            this.CHITIETCHITIEU = new HashSet<CHITIETCHITIEU>();
            this.CHITIETTHUNHAP = new HashSet<CHITIETTHUNHAP>();
            this.KHOANNO = new HashSet<KHOANNO>();
            this.KHOANVAY = new HashSet<KHOANVAY>();
        }
    
        public int ID { get; set; }
        public int MaTaiKhoan { get; set; }
        public Nullable<double> SoTien { get; set; }
        public string TenTaiKhoan { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETCHITIEU> CHITIETCHITIEU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTHUNHAP> CHITIETTHUNHAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOANNO> KHOANNO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOANVAY> KHOANVAY { get; set; }
        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
