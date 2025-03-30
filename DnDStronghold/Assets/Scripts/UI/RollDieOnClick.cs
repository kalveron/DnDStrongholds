using UnityEngine;

namespace SecMon
{
    public class RollDieOnClick : AbstractOnClick
    {
        [SerializeField]
        private ScriptableDie _dice;

        [SerializeField]
        private Roll _roll;

        protected override void OnButtonClicked()
        {
            var roll = _dice.RollDie(_roll);
            Debug.Log("Rolling: " + _roll);
            Debug.Log(_dice.LastRoll);
            Debug.Log(roll);
        }
    }
}