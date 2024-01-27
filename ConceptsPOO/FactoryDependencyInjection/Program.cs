// See https://aka.ms/new-console-template for more information

using FactoryDependencyInjection.Data.Concrets;
using FactoryDependencyInjection.Data.Factory;
using FactoryDependencyInjection.Data.Interfaces;
using FactoryDependencyInjection.Data.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var serviceProvider = Host.CreateDefaultBuilder().ConfigureServices(
    services =>
    {
        services.AddTransient<PaymentService>();
        services.AddTransient<DaviplataMethod>();
        services.AddTransient<NequiMethod>();
        services.AddTransient<IFactory, PaymentFactory>();
    }).Build();

    try
    {
        var paymentFactory = serviceProvider.Services.GetRequiredService<IFactory>();
        var method = paymentFactory.Create("Nequi");

        var paymentService = serviceProvider.Services.GetRequiredService<PaymentService>();
        paymentService.SetPaymentMethod(method);
        var result = paymentService.Proccess();
        Console.WriteLine(result);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }


