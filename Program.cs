namespace proniya
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
               name: "cart",
               pattern: "cart", defaults: new { controller = "home", action = "cart" });
            app.MapControllerRoute(
              name: "login",
              pattern: "login", defaults: new { controller = "home", action = "login" });
            app.MapControllerRoute(
              name: "Shop",
              pattern: "Shop", defaults: new { controller = "home", action = "Shop" });
            app.MapControllerRoute(
            name: "Singleproduct",
            pattern: "Singleproduct", defaults: new { controller = "home", action = "Singleproduct" });
            app.Run();
        }
    }
}