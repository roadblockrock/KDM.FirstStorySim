using KDM.FirstStorySim.Model.Survivors;
using System;
using System.Collections.Generic;
using System.Text;
using static KDM.FirstStorySim.Model.Enums;

namespace KDM.FirstStorySim.Services.Managers.SurvivorManagerService
{
    public class SurvivorManager : ISurvivorManager
    {

        public SurvivorManager()
        {
            InitSurvivors();
        }

        private Survivor[] _survivors { get; set; }
        public Survivor[] Survivors
        {
            get
            {
                return _survivors;
            }
        }


        public void InitSurvivors()
        {
            _survivors = new Survivor[4];

            // just add some dummy survivors for now
            _survivors[0] = new Survivor
            {
                Name = "Alph",
                Gender = Gender.Male
            };
            _survivors[1] = new Survivor
            {
                Name = "Brittany",
                Gender = Gender.Female
            };
            _survivors[2] = new Survivor
            {
                Name = "Charlie",
                Gender = Gender.Male
            };
            _survivors[3] = new Survivor
            {
                Name = "Louie",
                Gender = Gender.Male
            };
        }

    }
}
