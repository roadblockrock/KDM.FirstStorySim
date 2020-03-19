using System;
using System.Collections.Generic;
using System.Text;
using KDM.FirstStorySim.Model;

namespace KDM.FirstStorySim.Services.Mechanical.DiceRollerService
{
    public class TrueDiceRollerService : IDiceRollerService
    {
        private readonly Random _random;

        public TrueDiceRollerService()
        {
            // TODO add random seed
            _random = new Random();
        }

        public int RollD10()
        {
            return _random.Next(1, 11);
        }

        public bool D10Challenge(int minValue)
        {
            return RollD10() >= minValue;
        }

        public Enums.HitLocation RollHitLocationDice()
        {
            var result = _random.Next(0, 6);

            switch (result)
            {
                case 0:
                    return Enums.HitLocation.Head;
                case 1:
                    return Enums.HitLocation.Body;
                case 2:
                    return Enums.HitLocation.Body; // double the chance of getting Body
                case 3:
                    return Enums.HitLocation.Arm;
                case 4:
                    return Enums.HitLocation.Waist;
                case 5:
                    return Enums.HitLocation.Leg;
                default:
                    throw new Exception("Unexpected result from hit location dice roll");
            }

        }
    }
}
