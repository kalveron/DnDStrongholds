using RotaryHeart.Lib.SerializableDictionary;
using UnityEngine;

namespace SecMon.Guild
{
    [CreateAssetMenu(fileName = "Agent", menuName = "SecMon/Agent")]
    public class Agent : ScriptableObject
    {
        [SerializeField]
        private string _agentName;

        [SerializeField]
        private AgentClass _class;

        [SerializeField]
        private EncounterToProficiencySerializableDictionary _proficiencyCapabilties;

        [SerializeField]
        private EncounterToStatsSerializableDictionary _innateCapabilities;

        [SerializeField]
        private int _anonimity;

        [SerializeField]
        private Tool _equippedTool;

        [SerializeField]
        private Loyalty _loyalty;

        [SerializeField]
        private bool _dead;

        [SerializeField]
        private bool _captured;

        [SerializeField]
        private bool _available;

        [SerializeField]
        private bool _coerced;

        [SerializeField]
        private int _upkeep;

        public int GetBonusForEncounter(Encounter encounter)
        {
            var prof = _proficiencyCapabilties[encounter];
            return _innateCapabilities[encounter] + StatUtility.GetModifierForProficiency(prof);
        }

        public void AssignTool(Tool newTool)
        {
            _equippedTool = newTool;
        }

        public void CopyValues()
        {
        }

        [System.Serializable]
        private class EncounterToProficiencySerializableDictionary : SerializableDictionaryBase<Encounter, Proficiency>
        { }

        [System.Serializable]
        private class EncounterToStatsSerializableDictionary : SerializableDictionaryBase<Encounter, int>
        { }
    }
}