using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BT_C_.Models
{
    public class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NhanVienId { get; set; }

        [Required]
        [StringLength(255)]
        public string HoTen { get; set; }
        public string gioitinh { get; set; }

        public int age { get; set; }

        public int? PhongBanId { get; set; }

        public int? CongTyId { get; set; }

        public virtual PhongBan? PhongBanMaPhongBanNavigation { get; set; }

        public virtual CongTy? CongTyMaCongTyNavigation { get; set; }
    }
}
