using System;
using System.Collections.Generic;
using IOC_and_DependencyInjection_C_Sharp.DependencyInjection;
using IOC_and_DependencyInjection_C_Sharp.Services;
namespace IOC_and_DependencyInjection_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services =  new DIServiceCollection();
            //services.RegisterSingleton<RandomGuidGenerator>();
            services.RegisterTransient<IFoodService , LunchService>();

            var container = services.GenerateContainer();
            var serviceFirst = container.GetService<IFoodService>();
            var serviceSecond = container.GetService<IFoodService>();
            serviceFirst.eatSomething();
            serviceSecond.eatSomething();

        }
    }
}
