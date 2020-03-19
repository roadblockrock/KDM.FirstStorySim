using KDM.FirstStorySim.Model.Commands;
using KDM.FirstStorySim.Services.Managers.SurvivorManagerService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Services.Managers
{
    public interface ICommandManagerService
    {

    }

    public class CommandManagerService: ICommandManagerService
    {
        private readonly ISurvivorManager _survivorManager { get; set; }

        public void ExecuteCommand<T>(ICommand<T> command)
        {

        }
    }
}
