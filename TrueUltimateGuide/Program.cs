using Microsoft.Extensions.FileProviders;
using TrueUltimateGuide.CustomConstrains;
using TrueUltimateGuide.CustomMiddleware;
using TrueUltimateGuide.CustomModelBinders;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddTransient<MyCustomMiddleware>();
//builder.Services.AddRouting(options => {
//    options.ConstraintMap.Add("months", typeof(MonthsCustomConstraint));
//});
//var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
//{
//    WebRootPath = "myroot"
//});

builder.Services.AddControllers(options => {
    //options.ModelBinderProviders.Insert(0, new PersonBinderProvider());
});

builder.Services.AddControllers().AddXmlSerializerFormatters();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

//-- Run --

#region

//app.Run(async (HttpContext context) => {
//    await context.Response.WriteAsync("Hello");
//});

#endregion

//-- Middleware --

#region

//middlware 1
//app.Use(async (HttpContext context, RequestDelegate next) => {
//    await context.Response.WriteAsync("From Middleware 1\n");
//    await next(context);
//});

////middleware 2
////app.UseMiddleware<MyCustomMiddleware>();
//app.UseMyCustomMiddleware();
//app.UseHelloCustomMiddleware();

////middleware 3
//app.Run(async (HttpContext context) => {
//    await context.Response.WriteAsync("From Middleware 3\n");
//});

#endregion

//-- Routing --

#region

////enable routing
//app.UseRouting();

////creating endpoints
//app.UseEndpoints(endpoints =>
//{
//    //Eg: files/sample.txt
//    endpoints.Map("files/{filename}.{extension}", async context =>
//    {
//        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
//        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);

//        await context.Response.WriteAsync($"In files - {fileName} - {extension}");
//    });

//    //Eg: employee/profile/john
//    endpoints.Map("employee/profile/{EmployeeName:length(4,7):alpha=harsha}", async context =>
//    {
//        string? employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
//        await context.Response.WriteAsync($"In Employee profile - {employeeName}");
//    });


//    //Eg: products/details/
//    endpoints.Map("products/details/{id:int:range(1,1000)?}", async context => {
//        if (context.Request.RouteValues.ContainsKey("id"))
//        {
//            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
//            await context.Response.WriteAsync($"Products details - {id}");
//        }
//        else
//        {
//            await context.Response.WriteAsync($"Products details - id is not supplied");
//        }
//    });

//    //Eg: daily-digest-report/{reportdate}
//    endpoints.Map("daily-digest-report/{reportdate:datetime}", async context =>
//    {
//        DateTime reportDate = Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
//        await context.Response.WriteAsync($"In daily-digest-report - {reportDate.ToShortDateString()}");
//    });

//    //Eg: cities/cityid
//    endpoints.Map("cities/{cityid:guid}", async context =>
//    {
//        Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
//        await context.Response.WriteAsync($"City information - {cityId}");
//    });

//    //sales-report/2024/jan
//    endpoints.Map("sales-report/{year:int:min(1900)}/{month:months}", async context =>
//    {
//        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
//        string? month = Convert.ToString(context.Request.RouteValues["month"]);

//        if (month == "apr" || month == "jul" || month == "oct" || month == "jan")
//        {
//            await context.Response.WriteAsync($"sales report - {year} - {month}");
//        }
//        else
//        {
//            await context.Response.WriteAsync($"{month} is not allowed for sales report");
//        }
//    });

//    //sales-report/2024/jan
//    endpoints.Map("sales-report/2024/jan", async context =>
//    {
//        await context.Response.WriteAsync("Sales report exclusively for 2024 - jan");
//    });
//});

//app.Run(async context => {
//    await context.Response.WriteAsync($"No route matched at {context.Request.Path}");
//});



//app.UseStaticFiles(); //works with the web root path (myroot)
//app.UseStaticFiles(new StaticFileOptions()
//{
//    FileProvider = new PhysicalFileProvider(
// Path.Combine(builder.Environment.ContentRootPath, "mywebroot")
// )
//}); //works with "mywebroot"

//app.UseRouting();

//app.UseEndpoints(endpoints => {
//    endpoints.Map("/", async context =>
//    {
//        await context.Response.WriteAsync("Hello");
//    });
//});

#endregion

app.Run();