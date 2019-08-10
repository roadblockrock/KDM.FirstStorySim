using KDM.FirstStorySim.Model.Survivors;
using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Services.Managers.SurvivorManagerService
{
    public interface ISurvivorManager
    {
        Survivor[] Survivors { get; }

        void InitSurvivors();

    }
}
