using Learn_Factory_SendMessage.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// تزریق خدمات

// ایمیل به عنوان فرستنده پیام
//builder.Services.AddTransient<IMessageSender, EmailSender>();

// اس‌ام‌اس به عنوان فرستنده پیام (اگر فعال شود، کلاس EmailSender جایگزین می‌شود)
builder.Services.AddTransient<IMessageSender, SMSSender>();


builder.Services.AddTransient<NotificationService>(); // تزریق سرویس اعلان



var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
