using Microsoft.EntityFrameworkCore;

namespace BT_C_.data_access
{
    public class CompanyDbContext: DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options): base(options)
        {
        }

        public DbSet<Models.CongTy> CongTys { get; set; }
        public DbSet<Models.PhongBan> PhongBans { get; set; }
        public DbSet<Models.NhanVien> NhanViens { get; set; }   
    }
}
