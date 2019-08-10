using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.Survivors.SurvivorBodyParts
{
    public class Waist : SurvivorBodyPart
    {
        public Waist() : base() {

            // hardcode Waist to start with 1 armor
            ArmorPoints = 1;

        }
    }
}
