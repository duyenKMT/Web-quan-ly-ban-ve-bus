namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            VeThangs = new HashSet<VeThang>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Mã khách hàng")]
        public string maKH { get; set; }

        [StringLength(30)]
        [Display(Name = "Họ và tên")]
        public string tenKH { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh")]
        public DateTime ngaysinh { get; set; }

        [StringLength(3)]
        [Display(Name = "Giới tính")]
        public string gioitinh { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ")]
        public string diachi { get; set; }

        [StringLength(50)]
        [Display(Name = "Nơi làm việc")]
        public string noilamviec { get; set; }

        [StringLength(20)]
        [Display(Name = "SĐT")]
        public string sdt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeThang> VeThangs { get; set; }
    }
}
