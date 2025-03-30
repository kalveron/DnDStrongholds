using UnityEngine;

namespace SecMon.Guild
{
    [CreateAssetMenu(fileName = "Tool", menuName = "SecMon/Tool")]
    public class Tool : ScriptableObject
    {
        [SerializeField]
        private string _displayName;

        [SerializeField]
        private Quality _quality;

        [SerializeField]
        private Skill _skill;

        [SerializeField]
        private ScriptableDice _bonus;

        [SerializeField]
        private Encounter _encounter;

        [SerializeField]
        private int _timesUsed;

        [SerializeField]
        private Rarity _rarity;

        public string DisplayName => _displayName;
        public Quality Quality => _quality;
        public Skill Skill => _skill;
        public Encounter Encounter => _encounter;
    }
}