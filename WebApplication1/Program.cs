using Microsoft.AspNetCore.Routing.Constraints;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
            //app.MapGet("/", () => "Hello World!");

            //app.MapGet("/MKM", async context =>
            //{
            //    await context.Response.WriteAsync("mkm !"); /*Satic segment*/
            //});

            //app.MapGet(pattern:"/Fixed{name}", requestDelegate:async context =>
            //{
            //    var name = context.Request.RouteValues["name"];
            //    await context.Response.WriteAsync($"you are variable segment and your name is {name} !"); /*Varible segment*/
            //});

            //app.MapControllerRoute(name: "Mohamed",
            //    pattern: "{ Controller=Movies}/{Action=GetMoives}/{id}" );

            //app.MapControllerRoute(name:"default",
            //    pattern:"{ Controller}/{Action}/{id?}"

            //    );
            //app.MapControllerRoute(name: "default",
            //   pattern: "{ Controller}/{Action}/{id:int?}",
            //   defaults:new {Controller="Movies", action= "index" },
            //   constraints:new {id=new IntRouteConstraint()}
            //   );
            //app.MapControllerRoute(name: "default",
            //  pattern: "{ Controller}/{Action}/{id:regex(\\d{{2}}$)?}/{name:alpha}",
            //  defaults: new { Controller = "Movies", action = "index" },
            //  constraints: new { id = new IntRouteConstraint() }
            //  );
            //app.MapControllerRoute(name: "default",
            //   pattern: "{ Controller}/{Action}/{id:int?}"
            //   //defaults: new { Controller = "Movies", action = "index" },
            //   //constraints: new { id = new IntRouteConstraint() }
            //   );

            app.Run();
        }
    }
}
