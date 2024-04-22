using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BT_C_.Models
{
    public class PhongBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhongBanId { get; set; }

        [Required]
        [StringLength(255)]
        public string TenPhongBan { get; set; }

        public int CongTyId { get; set; }

        public virtual CongTy CongTy { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
