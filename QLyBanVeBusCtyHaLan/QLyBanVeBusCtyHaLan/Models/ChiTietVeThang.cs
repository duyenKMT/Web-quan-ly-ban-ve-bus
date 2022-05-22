namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietVeThang")]
    public partial class ChiTietVeThang
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã vé")]
        public string maVe { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày mua")]
        public DateTime? ngaymua { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Hạn sử dụng")]
        public string hansudung { get; set; }

        public virtual VeThang VeThang { get; set; }
    }
}
