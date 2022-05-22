namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietBaoCao")]
    public partial class ChiTietBaoCao
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        [Display(Name = "Mã báo cáo")]
        public string mabaocao { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        [Display(Name = "Mã loại vé")]
        public string maloaive { get; set; }

        public int? soluong { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Đơn giá bán")]
        public decimal? dongiaban { get; set; }

        public virtual BaoCaoBanVe BaoCaoBanVe { get; set; }

        public virtual LoaiVe LoaiVe { get; set; }
    }
}
