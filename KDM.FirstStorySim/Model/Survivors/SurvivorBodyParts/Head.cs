using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.Survivors.SurvivorBodyParts
{
    public class Head : SurvivorBodyPart
    {
        // head is always lightly injured
        public override bool IsLightlyInjured
        {
            get
            {
                return true;
            }
            set
            {

            }
        }
        public Head() : base() { }

    }
}
