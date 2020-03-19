using KDM.FirstStorySim.Model.Survivors;
using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.Commands.SurvivorCommands
{
    // Action that affects a single survivor
    public interface ISurvivorCommand : ICommand<Survivor>
    {
        int TargetSurvivorIndex { get; set; }
    }
}
