namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TuyenXe")]
    public partial class TuyenXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TuyenXe()
        {
            VeThangs = new HashSet<VeThang>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name = "Mã tuyến")]
        public string matuyen { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên tuyến")]
        public string tentuyen { get; set; }

        [StringLength(20)]
        [Display(Name = "Giờ hoạt động")]
        public string giohoatdong { get; set; }

        [StringLength(20)]
        [Display(Name = "Tần suất hoạt động")]
        public string tansuathoatdong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeThang> VeThangs { get; set; }
    }
}
