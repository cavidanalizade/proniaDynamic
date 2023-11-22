using Microsoft.EntityFrameworkCore;
using PraniaWA.DAL;

namespace PraniaWA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDBC>(options =>
       options.UseSqlServer("server=DESKTOP-QQIUMB0;database=PraniaWA;Trusted_connection=true;Integrated security=true;encrypt=false")
   );

            var app = builder.Build();

          
            app.UseStaticFiles();



            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}