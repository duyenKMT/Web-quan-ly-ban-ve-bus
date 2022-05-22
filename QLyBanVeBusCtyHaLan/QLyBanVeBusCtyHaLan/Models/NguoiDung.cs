namespace QLyBanVeBusCtyHaLan.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [StringLength(10)]
        public string id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã quyền")]
        public string maquyen { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Họ và tên")]
        public string tennguoidung { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Tên đăng nhập")]
        public string tendangnhap { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Mật khẩu")]
        public string matkhau { get; set; }

        public virtual Quyen Quyen { get; set; }
    }
}
