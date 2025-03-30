using UnityEngine;
using UnityEngine.UI;

namespace SecMon
{
    [RequireComponent(typeof(Button))]
    public abstract class AbstractOnClick : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            if (TryGetComponent<Button>(out var button))
            {
                _button = button;
                _button.onClick.AddListener(OnButtonClicked);
            }
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
        }

        protected abstract void OnButtonClicked();
    }
}