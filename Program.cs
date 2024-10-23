// using Microsoft.EntityFrameworkCore;
// using TodoApi.Models;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container.

// builder.Services.AddControllers();
// builder.Services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// var app = builder.Build();


// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI(c =>
//     {
//         c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
//         c.RoutePrefix = string.Empty;
//     });
// }

// app.UseDefaultFiles();//Cho phép sử dụng index.html làm mặc định
// app.UseStaticFiles();

// // app.UseHttpsRedirection();

// app.UseAuthorization();

// app.MapControllers();

// app.Run();

using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Thêm dịch vụ CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5129") // Cho phép giao diện trên localhost truy cập API
              .AllowAnyMethod()  // Cho phép tất cả các phương thức HTTP: GET, POST, PUT, DELETE
              .AllowAnyHeader(); // Cho phép mọi header
    });
});

// Thêm các dịch vụ khác
builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
        c.RoutePrefix = string.Empty;
    });
}

// Cho phép sử dụng index.html làm tệp mặc định và phục vụ các tệp tĩnh
app.UseDefaultFiles();
app.UseStaticFiles();

// Kích hoạt CORS trước Authorization
app.UseCors();

// Bỏ qua HTTPS nếu chưa bật SSL
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
