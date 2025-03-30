using UnityEngine;

namespace SecMon.Guild
{
    [CreateAssetMenu(fileName = "Task", menuName = "SecMon/Task")]
    public class Task : ScriptableObject
    {
        [SerializeField]
        private TaskTarget _target;

        [Range(1, 4)]
        [SerializeField]
        private int _duration;

        [SerializeField]
        private int _daysRemaining;

        [SerializeField]
        private Risk _risk;

        public TaskTarget Target => _target;
        public int Duration => _duration;
        public int DaysRemaining => _daysRemaining;
        public Risk Risk => _risk;
    }
}