# webappindividual_net5

MODIFICAÇÕES ANTERIORES AO COMMIT
de Edward Amagasaki

dotnet new webapp --auth Individual -o

-Cria um aplicativo web razor com banco de dados SQLite.

CONFIGURAÇÕES ADICIONAIS PARA O SISTEMA DE IDENTIDADE..

services.Configure<IdentityOptions>(options =>
    {
        // CONFIGURAÇÕES DE SENHAS..
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireNonAlphanumeric = true;
        options.Password.RequireUppercase = true;
        options.Password.RequiredLength = 6;
        options.Password.RequiredUniqueChars = 1;

        // CONFIGURAÇÕES DE BLOQUEIOS..
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.AllowedForNewUsers = true;

        // CONFIGURAÇÕES DE USUÁRIOS..
        options.User.AllowedUserNameCharacters =
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
        options.User.RequireUniqueEmail = false;
    });

    services.ConfigureApplicationCookie(options =>
    {
        // CONFIGURAÇÕES DE COOKIES..
        options.Cookie.HttpOnly = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

        options.LoginPath = "/Identity/Account/Login";
        options.AccessDeniedPath = "/Identity/Account/AccessDenied";
        options.SlidingExpiration = true;
    });

FORMULÁRIOS PARA O REGISTRO

public void ConfigureServices(IServiceCollection services)
{
    //services.AddDbContext<ApplicationDbContext>(options =>
    //    options.UseSqlServer(
    //        Configuration.GetConnectionString("DefaultConnection")));
    //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    //    .AddEntityFrameworkStores<ApplicationDbContext>();
    services.AddControllersWithViews();
    services.AddRazorPages();
}

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.UI
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet tool install -g dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator identity -dc do0.Data.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout;Account.RegisterConfirmation"

Formulários para auteração na pasta: Areas/Identity/Account
