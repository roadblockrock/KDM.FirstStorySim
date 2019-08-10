using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.Survivors.Weapons
{
    public class FoundingStone : Weapon
    {
        public FoundingStone()
        {
            // hard code stats for now 
            Speed = 2;
            Accuracy = 7;
            Strength = 1;
            IsDeadly = false;

        }
    }
}
