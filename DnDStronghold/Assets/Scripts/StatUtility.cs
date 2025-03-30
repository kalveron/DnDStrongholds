using System.Collections.Generic;
using UnityEngine;

namespace SecMon.Guild
{
    public static class StatUtility
    {
        private static Dictionary<Proficiency, int> _flatModifier = new()
        {
            {Proficiency.None, 0},
            {Proficiency.Other, 2},
            {Proficiency.Secondary, 4},
            {Proficiency.Primary, 6},
        };

        public static int GetModifierForProficiency(Proficiency prof)
        {
            return _flatModifier[prof];
        }
    }
}