using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SecMon
{
    public class Dice
    {
        private HashSet<Die> _diceCollection;

        private List<Vector2Int> _lastRolls = new List<Vector2Int>();
        public List<Vector2Int> LastRolls => new List<Vector2Int>(_lastRolls);

        public Dice(HashSet<Die> dice)
        {
            _diceCollection = dice;
        }

        public int RollDice(Roll roll)
        {
            switch (roll)
            {
                case Roll.Disadvantage:
                    return RollDisadvantage();

                case Roll.Advantage:
                    return RollAdvantage();

                case Roll.Standard:
                default:
                    return RollStandard();
            }
        }

        private int RollStandard()
        {
            var result = 0;
            foreach (var d in _diceCollection)
            {
                result += d.RollDie(Roll.Standard);
            }
            _lastRolls = _diceCollection.Select(d => d.LastRoll).ToList();
            return result;
        }

        private int RollAdvantage()
        {
            var result1 = RollStandard();
            //var history1 = _diceCollection.Select(d => d.LastRoll).ToList();
            var history1 = LastRolls;
            var result2 = RollStandard();
            //var history2 = _diceCollection.Select(d => d.LastRoll).ToList();
            var history2 = LastRolls;

            _lastRolls.Clear();
            for (int i = 0; i < history1.Count; i++)
            {
                var r1 = history1[i];
                var r2 = history2[i];
                _lastRolls.Add(new Vector2Int(r1.x, r2.x));
            }

            return Mathf.Max(result1, result2);
        }

        private int RollDisadvantage()
        {
            var result1 = RollStandard();
            var history1 = LastRolls;
            var result2 = RollStandard();
            var history2 = LastRolls;

            _lastRolls.Clear();
            for (int i = 0; i < history1.Count; i++)
            {
                var r1 = history1[i];
                var r2 = history2[i];
                _lastRolls.Add(new Vector2Int(r1.x, r2.x));
            }
            return Mathf.Min(result1, result2);
        }
    }
}