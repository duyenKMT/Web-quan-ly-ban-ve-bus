namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoCaoBanVe")]
    public partial class BaoCaoBanVe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaoCaoBanVe()
        {
            ChiTietBaoCaos = new HashSet<ChiTietBaoCao>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Mã báo cáo")]
        public string mabaocao { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã nhân viên")]
        public string maNV { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã tuyến")]
        public string matuyen { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày lập")]
        public DateTime ngaylap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBaoCao> ChiTietBaoCaos { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
