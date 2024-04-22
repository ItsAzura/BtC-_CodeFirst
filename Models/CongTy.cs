using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BT_C_.Models
{
    public class CongTy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CongTyId { get; set; }

        [Required]
        [StringLength(255)]
        public string TenCongTy { get; set; }

        public virtual ICollection<PhongBan> PhongBans { get; set; }
    }
}
