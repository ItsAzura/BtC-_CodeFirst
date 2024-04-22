namespace BT_C_
{
    using BT_C_.data_access;
    using BT_C_.Models;
    using Microsoft.EntityFrameworkCore;

    public static class ConsoleResult
    {
        public static void Show(this WebApplication webApplication)
        {
            using (var scope = webApplication.Services.CreateScope())
            {
                var applicationDbContext = scope.ServiceProvider.GetRequiredService<CompanyDbContext>();

                var result = applicationDbContext.NhanViens.Where(nv => nv.PhongBanId == 4 && (nv.age >= 30 && nv.age <=40))
                    .Include(NhanVien => NhanVien.PhongBanMaPhongBanNavigation)
                    .Include(NhanVien => NhanVien.CongTyMaCongTyNavigation).ToList();

                Console.WriteLine("Result: ");

                result.ForEach(nv => Console.WriteLine($"NhanVien name: {nv.HoTen} - age: {nv.age} - PhongBan: {nv.PhongBanMaPhongBanNavigation?.TenPhongBan} - CongTy: {nv.CongTyMaCongTyNavigation?.TenCongTy}"));
            }
        }
    }
}
