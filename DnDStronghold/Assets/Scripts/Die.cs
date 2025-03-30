using UnityEngine;

namespace SecMon
{
    public class Die
    {
        public int Sides { get; private set; }

        public Vector2Int LastRoll { get; private set; }

        public Die()
        {
            Sides = 20;
            LastRoll = new Vector2Int(0, 0);
        }

        public Die(int sides)
        {
            Sides = sides;
            LastRoll = new Vector2Int(0, 0);
        }

        public Die(Die die)
        {
            Sides = die.Sides;
            LastRoll = die.LastRoll;
        }

        public int RollDie(Roll roll)
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
            var result = GetResult();
            LastRoll = new Vector2Int(result, 0);
            return result;
        }

        private int RollAdvantage()
        {
            var rollOne = GetResult();
            var rollTwo = GetResult();
            var result = Mathf.Max(rollOne, rollTwo);
            LastRoll = new Vector2Int(rollOne, rollTwo);
            return result;
        }

        private int RollDisadvantage()
        {
            var rollOne = GetResult();
            var rollTwo = GetResult();
            var result = Mathf.Min(rollOne, rollTwo);
            LastRoll = new Vector2Int(rollOne, rollTwo);
            return result;
        }

        private int GetResult()
        {
            return Random.Range(1, Sides + 1);
        }
    }
}