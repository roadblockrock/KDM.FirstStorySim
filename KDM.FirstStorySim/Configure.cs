using KDM.FirstStorySim.Services.Managers.SurvivorManagerService;
using KDM.FirstStorySim.Services.Mechanical.DiceRollerService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim
{
    public static class Configure
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            // register dice roller
            services.AddSingleton<IDiceRollerService, TrueDiceRollerService>();

            // register survivor manager
            services.AddSingleton<ISurvivorManager, SurvivorManager>();

            return services;
        }
    }
}
