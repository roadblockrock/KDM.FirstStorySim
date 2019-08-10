using System;
using System.Collections.Generic;
using System.Text;
using static KDM.FirstStorySim.Model.Enums;

namespace KDM.FirstStorySim.Services.Mechanical.DiceRollerService
{
    public interface IDiceRollerService
    {
        /// <summary>
        /// Rolls a 10 sided dice and gets the result, 1-10
        /// </summary>
        /// <returns>The result of the roll</returns>
        int RollD10();

        /// <summary>
        /// Rolls a D10 and returns true if it is greater than or equal to the given min value
        /// </summary>
        /// <param name="minValue">The minimum value for the dice</param>
        /// <returns>True if the result is greater than or equal to the min value</returns>
        bool D10Challenge(int minValue);

        /// <summary>
        /// Rolls the hit location dice and gets the result
        /// </summary>
        /// <returns>The result of the roll</returns>
        HitLocation RollHitLocationDice();



    }
}
