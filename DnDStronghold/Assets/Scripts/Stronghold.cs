using UnityEngine;

namespace SecMon.Guild
{
    [CreateAssetMenu(fileName = "Stronghold", menuName = "SecMon/Stronghold")]
    public class Stronghold : ScriptableObject
    {
        //[SerializeField]
        private string _displayName;

        [SerializeField]
        private GeographicLocation _location;

        [SerializeField]
        private Proximity _proximity;

        [SerializeField]
        private int _level;

        [SerializeField]
        private StrongholdFocus _focusType;

        [SerializeField]
        private int _entryDC;

        [SerializeField]
        private int _reconDC;

        [SerializeField]
        private int _exitDC;

        [SerializeField]
        private int _exitDiscoveredDC;

        [Range(0, 1)]
        [SerializeField]
        private float _knowledgeLevel;

        [SerializeField]
        private bool _alerted;

        [SerializeField]
        private bool _hidden;

        [SerializeField]
        private string _notes;

        public string Name { get; private set; }
        public bool Hidden { get; private set; }

        public string Notes { get; private set; }

        public override string ToString()
        {
            return "Name: " + name +
                 "\nLocation: " + _location +
                 "\nProximity: " + _proximity +
                 "\nLevel: " + _level +
                 "\nFocus: " + _focusType +
                 "\nEntry: " + _focusType +
                 "\nRecon: " + _focusType +
                 "\nExit: " + _focusType +
                 "\nDiscover: " + _focusType

                 ;
        }
    }
}