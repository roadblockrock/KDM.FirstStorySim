using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.Survivors.Weapons
{
    public class FistAndTooth : Weapon
    {
        public FistAndTooth()
        {
            // hard code stats for now 
            Speed = 2;
            Accuracy = 8;
            Strength = 0;
            IsDeadly = true;
        }

        
    }
}
