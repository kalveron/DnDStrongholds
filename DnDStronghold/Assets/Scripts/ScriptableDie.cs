using UnityEngine;

namespace SecMon
{
    [CreateAssetMenu(fileName = "ScriptableDice", menuName = "SecMon/ScriptableDie")]
    public class ScriptableDie : ScriptableObject
    {
        [SerializeField]
        private int _sides;

        private Die _myDie;
        public Vector2Int LastRoll => _myDie.LastRoll;

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
            if (_myDie == null)
            {
                Init();
            }
            return _myDie.RollDie(Roll.Standard);
        }

        private int RollAdvantage()
        {
            if (_myDie == null)
            {
                Init();
            }
            return _myDie.RollDie(Roll.Advantage);
        }

        private int RollDisadvantage()
        {
            if (_myDie == null)
            {
                Init();
            }
            return _myDie.RollDie(Roll.Disadvantage);
        }

        private void Init()
        {
            _myDie = new Die(_sides);
        }
    }
}