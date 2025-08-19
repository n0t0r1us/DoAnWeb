using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Web_61131562.Models.EF;

namespace Web_61131562.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<ThongKe> ThongKes { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<QuangCao> QuangCaos { get; set; }
        public DbSet<GioiThieu> GioiThieus { get; set; }
        public DbSet<TinTuc> TinTucs { get; set; }
        public DbSet<CaiDatHeThong> CaiDatHeThongs { get; set; }
        public DbSet<LoaiMH> LoaiMHs { get; set; }
        public DbSet<MatHang> MatHangs { get; set; }
        public DbSet<AnhMH> AnhMHs { get; set; }
        public DbSet<LienHe> LienHes { get; set; }
        public DbSet<DonGia> DonGias { get; set; }
        public DbSet<CTDH> CTDHs { get; set; }
        public DbSet<DangKy> DangKys { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}