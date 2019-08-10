using KDM.FirstStorySim.Model.Survivors.SurvivorBodyParts;
using KDM.FirstStorySim.Model.Survivors.SurvivorBodyPart;
using KDM.FirstStorySim.Model.Survivors.Weapons;
using System;
using System.Collections.Generic;
using System.Text;
using static KDM.FirstStorySim.Model.Enums;
using System.Diagnostics;

namespace KDM.FirstStorySim.Model.Survivors
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Survivor
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public int Survival { get; set; }

        public int SurvivalLimit { get; }

        
        #region Stats

        public int Movement { get; set; }
        public int Strength { get; set; }
        public int Accuracy { get; set; }
        public int Evasion { get; set; }
        public int Luck { get; set; }
        public int Speed { get; set; }

        public int Understanding { get; set; }
        public int Courage { get; set; }

        #endregion

        #region Body

        public Brain Brain { get; set; }

        public Head Head { get; set; }

        public Body Body { get; set; }

        public Arm Arm { get; set; }

        public Waist Waist { get; set; }

        public Legs Legs { get; set; }

        #endregion

        public Weapon EquippedWeapon { get; set; }

        public Survivor()
        {
            Survival = 1;
            SurvivalLimit = 1;
            Movement = 0;
            Strength = 0;
            Accuracy = 0;
            Evasion = 0;
            Luck = 0;
            Speed = 0;
            Understanding = 0;
            Courage = 0;

            Brain = new Brain();
            Head = new Head();
            Body = new Body();
            Arm = new Arm();
            Waist = new Waist();
            Legs = new Legs();

            EquippedWeapon = new FoundingStone();

        }

        private string DebuggerDisplay
        {
            get
            {
                return Name;
            }
        }

    }
}
