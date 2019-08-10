using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.Survivors.Weapons
{
    public abstract class Weapon
    {

        // these should probably be moved to an attack profile object
        public int Speed { get; set; }
        public int Accuracy { get; set; }
        public int Strength { get; set; }

        // this is the only weapon tag to worry about for First Story
        public bool IsDeadly { get; set; }


    }
}
