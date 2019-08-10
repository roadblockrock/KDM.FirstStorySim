using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.Survivors.SurvivorBodyParts
{
    public abstract class SurvivorBodyPart
    {

        public virtual bool IsLightlyInjured { get; set; }

        public bool IsHeavilyInjured { get; set; }

        public int ArmorPoints { get; set; }

        public SurvivorBodyPart()
        {
            IsLightlyInjured = false;
            IsHeavilyInjured = false;
            ArmorPoints = 0;
        }

    }
}
