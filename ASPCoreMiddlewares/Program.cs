namespace ASPCoreMiddlewares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            //app.Run(async (context) =>
            //{
            //await context.Response.WriteAsync("welcome to asp.netcore 8");

            //});
            app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync("welcome to asp.netcore 8");
                await next(context); 

            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("AccioJob");

            });

            app.Run();
        }
    }
}
