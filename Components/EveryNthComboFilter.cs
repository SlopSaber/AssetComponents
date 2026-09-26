using UnityEngine;
using UnityEngine.Events;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/SaberComponents/EveryNthComboFilter")]
    [RequireComponent(typeof(EventManager))]
    public class EveryNthComboFilter : MonoBehaviour
    {
        [Tooltip("Triggers the event every specified number of combo")]
        public int comboStep = 50;
        public UnityEvent nthComboReached;

        private EventManager eventManager;
        
        private void OnEnable()
        {
            if (eventManager == null) eventManager = GetComponent<EventManager>();
            eventManager.comboChanged.AddListener(OnComboStep);
        }

        private void OnDisable()
        {
            eventManager.comboChanged.RemoveListener(OnComboStep);
        }

        private void OnComboStep(int combo)
        {
            if (comboStep > 0 && combo != 0 && combo % comboStep == 0)
            {
                nthComboReached.Invoke();
            }
        }
    }
}
