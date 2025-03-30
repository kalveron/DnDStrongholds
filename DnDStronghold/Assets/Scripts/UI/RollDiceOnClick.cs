using UnityEngine;

namespace SecMon
{
    public class RollDiceOnClick : AbstractOnClick
    {
        [SerializeField]
        private ScriptableDice _dice;

        [SerializeField]
        private Roll _roll;

        protected override void OnButtonClicked()
        {
            var roll = _dice.RollDice(_roll);
            Debug.Log("Rolling: " + _roll);
            foreach (var die in _dice.LastRolls)
            {
                Debug.Log(die);
            }
            Debug.Log(roll);
        }
    }
}