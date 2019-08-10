using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.HL
{
    public class HitLocation
    {

        public string Name { get; set; }

        public Reaction Reaction { get; set; }

        public CriticalEffect CriticalEffect { get; set; }

        public bool IsImpervious { get; set; }



    }
}
