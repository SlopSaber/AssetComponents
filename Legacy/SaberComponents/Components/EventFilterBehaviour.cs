using UnityEngine;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/Saber Components/EventFilterBehaviour")]
    public class EventFilterBehaviour : MonoBehaviour
    {
        private EventManager eventManager;

        protected EventManager EventManager
        {
            get
            {
                if (eventManager == null)
                {
                    eventManager = GetComponent<EventManager>();
                }
                return eventManager;
            }
        }
    }
}