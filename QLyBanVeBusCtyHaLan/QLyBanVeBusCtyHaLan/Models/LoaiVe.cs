namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiVe")]
    public partial class LoaiVe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiVe()
        {
            ChiTietBaoCaos = new HashSet<ChiTietBaoCao>();
            VeThangs = new HashSet<VeThang>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Mã loại")]
        public string maloai { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Đơn giá")]
        public decimal? dongia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBaoCao> ChiTietBaoCaos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeThang> VeThangs { get; set; }
    }
}
