using KDM.FirstStorySim.Model.Survivors;
using System;
using System.Collections.Generic;
using System.Text;
using static KDM.FirstStorySim.Model.Commands.CommandEnums;

namespace KDM.FirstStorySim.Model.Commands.SurvivorCommands
{
    public class ModifySurvivalCommand : ISurvivorCommand
    {
        // interface fields
        public int TargetSurvivorIndex { get; set; }

        private readonly SurvivalModifyAction _action;
        private readonly int _amount;

        public ModifySurvivalCommand(SurvivalModifyAction action, int amount)
        {
            _action = action;
            _amount = amount;
        }

        public void ExecuteAction(Survivor target)
        {
            if(_action == SurvivalModifyAction.Increase)
            {
                target.Survival = Math.Min(target.SurvivalLimit, target.Survival + _amount);
            }
            else
            {
                target.Survival = Math.Max(0, target.Survival - _amount);
            }
        }

        public void Undo()
        {
            throw new NotImplementedException("TODO");
        }
    }
}
