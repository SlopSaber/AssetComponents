using UnityEngine;
using UnityEngine.Events;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/SaberComponents/ComboReachedEvent")]
    [RequireComponent(typeof(EventManager))]
    public class ComboReachedEvent : MonoBehaviour
    {
        [Tooltip("The number combo the event should be triggered at")]
        public int comboTarget = 50;
        public UnityEvent nthComboReached;

        private EventManager eventManager;
        
        private void OnEnable()
        {
            if (eventManager == null) eventManager = GetComponent<EventManager>();
            eventManager.comboChanged.AddListener(OnComboReached);
        }

        private void OnDisable()
        {
            eventManager.comboChanged.RemoveListener(OnComboReached);
        }

        private void OnComboReached(int combo)
        {
            if (combo == comboTarget)
            {
                nthComboReached.Invoke();
            }
        }
    }
}
