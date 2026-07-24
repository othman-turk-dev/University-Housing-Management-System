using Business_Layer.Authorization;
using Business_Layer.Global.Enums;
using Business_Layer.Interfaces;
using Business_Layer.Services;
using Data_Access_Layer.Data;
using Data_Access_Layer.Repository.Implementaions;
using Data_Access_Layer.Repository.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Serilog;
using System.Security.Claims;
using System.Text;
using System.Threading.RateLimiting;


var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateLogger();

builder.Host.UseSerilog();


// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(options => 
{
    options.AddPolicy("ApiCorsPolicy", policy =>
    { 
        policy.WithOrigins("https://localhost:7282", "http://localhost:5172")
        .AllowAnyHeader().AllowAnyMethod(); 
    }); 
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {

        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero,


        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
    };
});

builder.Services.AddAuthorization(options =>
{
    foreach (UserPermission permission in Enum.GetValues(typeof(UserPermission)))
    {
        options.AddPolicy(
            permission.ToString(),
            policy => policy.Requirements.Add(new PermissionRequirement(permission)));
    }
});

builder.Services.AddSingleton<IAuthorizationHandler, PermissionHandler>();

builder.Services.AddRateLimiter(options =>
{
    options.RejectionStatusCode = StatusCodes.Status429TooManyRequests;

    // Login
    options.AddPolicy("AuthLimiter", context =>
    {
        var ip = context.Connection.RemoteIpAddress?.ToString() ?? "unknown";

        return RateLimitPartition.GetSlidingWindowLimiter(
            ip,
            _ => new SlidingWindowRateLimiterOptions
            {
                PermitLimit = 5,
                Window = TimeSpan.FromMinutes(1),
                SegmentsPerWindow = 6,
                QueueLimit = 0
            });
    });

    //All API
    options.AddPolicy("ApiLimiter", context =>
    {
        var key = context.User.Identity?.IsAuthenticated == true
            ? context.User.FindFirst(ClaimTypes.NameIdentifier)!.Value
            : context.Connection.RemoteIpAddress?.ToString() ?? "unknown";

        return RateLimitPartition.GetFixedWindowLimiter(
            key,
            _ => new FixedWindowRateLimiterOptions
            {
                PermitLimit = 60,
                Window = TimeSpan.FromMinutes(1),
                QueueLimit = 0
            });
    });
});


// DAL
builder.Services.AddScoped<ISaleRepositry, SaleRepositry>();
builder.Services.AddScoped<IUserRepositry, UserRepositry>();
builder.Services.AddScoped<IRoomRepositry, RoomRepositry>();
builder.Services.AddScoped<IBankRepositry, BankRepositry>();
builder.Services.AddScoped<IStudentRepositry, StudentRepositry>();
builder.Services.AddScoped<IProductRepositry, ProductRepositry>();
builder.Services.AddScoped<IViolationRepositry, ViolationRepositry>();
builder.Services.AddScoped<ITransactionManager, TransactionManager>();
builder.Services.AddScoped<ISaleDetailRepositry, SaleDetailRepositry>();
builder.Services.AddScoped<ISubscriptionRepositry, SubscriptionRepositry>();
builder.Services.AddScoped<IViolationTypeRepositry, ViolationTypeRepositry>();
builder.Services.AddScoped<ISpecializationRepositry, SpecializationRepositry>();
builder.Services.AddScoped<ISubscriptionTypeRepositry, SubscriptionTypeRepositry>();
builder.Services.AddScoped<IStudentSubscriptionRepositry, StudentSubscriptionRepositry>();

// BL
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IJwtService, JwtService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IBankService, BankService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ISettingsService, SettingsService>();
builder.Services.AddScoped<IViolationService, ViolationService>();
builder.Services.AddScoped<ISaleDetailService, SaleDetailService>();
builder.Services.AddScoped<ICurrentUserService,CurrentUserService>();
builder.Services.AddScoped<IViolationTypeService, ViolationTypeService>();
builder.Services.AddScoped<ISpecializationService, SpecializationService>();
builder.Services.AddScoped<ISubscriptionTypeService, SubscriptionTypeService>();
builder.Services.AddScoped<IStudentSubscriptionService, StudentSubscriptionService>();


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    // ===============================
    // 1) Define the JWT Bearer security scheme
    // ===============================
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",       // lowercase per RFC 7235
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter your JWT token. The 'Bearer ' prefix is added automatically."
    });

    // ===============================
    // 2) Require the Bearer scheme — Swashbuckle v10 delegate syntax
    // ===============================
    options.AddSecurityRequirement(document =>
    {
        var schemeRef = new OpenApiSecuritySchemeReference("Bearer", document);
        return new OpenApiSecurityRequirement
        {
            [schemeRef] = []
        };
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("ApiCorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.UseRateLimiter();

app.MapControllers();

app.Run();
