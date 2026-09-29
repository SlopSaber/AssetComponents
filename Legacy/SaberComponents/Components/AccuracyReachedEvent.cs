using UnityEngine;
using UnityEngine.Events;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/SaberComponents/AccuracyReachedEvent")]
    [RequireComponent(typeof(EventManager))]
    public class AccuracyReachedEvent : MonoBehaviour
    {
        [Tooltip("Percentage accuracy between 0 and 1")]
        public float target = 1f;
        public UnityEvent accuracyReached;
        public UnityEvent accuracyHigherThanTarget;
        public UnityEvent accuracyLowerThanTarget;

        private EventManager eventManager;
        private float prevAccuracy;

        private void OnEnable()
        {
            if (eventManager == null) eventManager = GetComponent<EventManager>();
            eventManager.accuracyChanged.AddListener(OnAccuracyReached);
            prevAccuracy = 1f;
        }

        private void OnDisable()
        {
            eventManager.accuracyChanged.RemoveListener(OnAccuracyReached);
        }

        private void OnAccuracyReached(float accuracy)
        {
            if ((prevAccuracy > target && accuracy < target) || (prevAccuracy < target && accuracy > target))
            {
                accuracyReached.Invoke();
            }
            if (prevAccuracy < target && accuracy > target)
            {
                accuracyHigherThanTarget.Invoke();
            }
            if (prevAccuracy > target && accuracy < target)
            {
                accuracyLowerThanTarget.Invoke();
            }
            prevAccuracy = accuracy;
        }
    }
}
