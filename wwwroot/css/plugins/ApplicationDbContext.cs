using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoftwareCompany.Models;
using  SoftwareCompany.Models;
//using SettingsKey = SoftwareCompany.Models;

namespace SoftwareCompany.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<About_us> Aboutus { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        //public virtual DbSet<SettingsKey> SettingsKey { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }

        

    }
}