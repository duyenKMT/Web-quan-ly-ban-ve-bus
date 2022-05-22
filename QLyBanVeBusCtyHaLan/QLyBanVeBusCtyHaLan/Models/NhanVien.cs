namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
       

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            BaoCaoBanVes = new HashSet<BaoCaoBanVe>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name ="Mã nhân viên")]
        public string maNV { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Họ và tên")]
        public string tenNV { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh")]
        public DateTime? ngaysinh { get; set; }

        [StringLength(3)]
        [Display(Name = "Giới tính")]
        public string gioitinh { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa chỉ")]
        public string diachi { get; set; }

        [StringLength(20)]
        [Display(Name = "CMND")]
        public string cmnd { get; set; }

        [StringLength(20)]
        [Display(Name = "SĐT")]
        public string sdt { get; set; }

        [StringLength(20)]
        [Display(Name = "Chức vụ")]
        public string chucvu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoCaoBanVe> BaoCaoBanVes { get; set; }
        public object[] id { get; internal set; }
    }
}
