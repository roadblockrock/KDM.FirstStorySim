using KDM.FirstStorySim.Model.Commands.SurvivorCommands;
using KDM.FirstStorySim.Services.Managers.SurvivorManagerService;
using KDM.FirstStorySim.Services.Mechanical.DiceRollerService;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace KDM.FirstStorySim
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .ConfigureServices()
                .BuildServiceProvider();

            var roller = serviceProvider.GetService<IDiceRollerService>();

            var survManager = serviceProvider.GetService<ISurvivorManager>();

            survManager.ExecuteCommandByIndex(0, new ModifySurvivalCommand(Model.Commands.CommandEnums.SurvivalModifyAction.Decrease, 1));

            Console.WriteLine($"Rolled hit location: {roller.RollHitLocationDice().ToString()}");

        }
    }
}
