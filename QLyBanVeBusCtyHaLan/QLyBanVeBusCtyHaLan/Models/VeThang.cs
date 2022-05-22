namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VeThang")]
    public partial class VeThang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VeThang()
        {
            ChiTietVeThangs = new HashSet<ChiTietVeThang>();
        }

        [Key]
        [StringLength(10)]
        public string maVe { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã khách hàng")]
        public string maKH { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã loại")]
        public string maloai { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã tuyến")]
        public string matuyen { get; set; }

        [StringLength(50)]
        [Display(Name = "Lộ trình")]
        public string lotrinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietVeThang> ChiTietVeThangs { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual LoaiVe LoaiVe { get; set; }

        public virtual TuyenXe TuyenXe { get; set; }
    }
}
