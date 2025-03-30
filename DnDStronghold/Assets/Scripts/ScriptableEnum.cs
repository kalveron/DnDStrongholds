using System.Collections.Generic;
using UnityEngine;

namespace SecMon
{
    [CreateAssetMenu(fileName = "NewScriptableEnum", menuName = "SecMon/ScriptableEnum")]
    public class ScriptableEnum : ScriptableObject
    {
        [SerializeField]
        private string _displayName;

        [SerializeField]
        private List<string> _values;

        public string DisplayName => _displayName;
        public List<string> Values => new List<string>(_values);
    }
}