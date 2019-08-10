using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.Survivors.SurvivorBodyPart
{
    public class Brain
    {

        public int Insanity { get; set; }

        public bool IsHeavilyInjured { get; set; }

        public Brain()
        {
            Insanity = 0;
            IsHeavilyInjured = false;
        }

    }
}
