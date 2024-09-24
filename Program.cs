using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using WbSailerNotifier;
using WbSailerNotifier.Configurations;
using WbSailerNotifier.DataAccess;
using WbSailerNotifier.DataAccess.Context;
using WbSailerNotifier.DataAccess.Interfaces;
using WbSailerNotifier.DataAccess.Repositories;
using WbSailerNotifier.Interfaces;
using WbSailerNotifier.Services;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddOptions();


var dataBaseConfig = builder.Configuration.GetSection("DataBaseConfiguration").Get<DataBaseConfiguration>();
var wbConfiguration = builder.Configuration.GetSection("WbConfiguration").Get<WbConfiguration>();


builder.Services.AddDbContext<DatabaseContext>(options => options.UseNpgsql(dataBaseConfig.FullConnectionString,
    x => x.MigrationsHistoryTable(
        DatabaseContext.DefaultMigrationHistoryTableName,
        DatabaseContext.DefaultSchema
    )));
builder.Services.AddTransient<IDatabaseContextFactory>(_ => new DatabaseContextFactory(dataBaseConfig.FullConnectionString));
builder.Services.AddTransient<MigrationHelper>();

builder.Services.AddTransient<IOrderRepository, OrderRepository>();

builder.Services.Configure<WbConfiguration>(builder.Configuration.GetSection("WbConfiguration"));
builder.Services.AddTransient<IWbOrderService, WbOrderService>();

builder.Services.AddHttpClient<IWbOrderService, WbOrderService>();


builder.Services.AddHostedService<Worker>();


var host = builder.Build();
host.Run();
