using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/SaberComponents/EventManager")]
    public class EventManager : MonoBehaviour
    {
        [Serializable] public class ComboChangedEvent : UnityEvent<int> { }
        [Serializable] public class AccuracyChangedEvent : UnityEvent<float> { }
        [Serializable] public class BoostColorsToggledEvent : UnityEvent<bool> { }

        [Tooltip("Triggered when a note is cut with the correct saber in the correct direction")]
        [FormerlySerializedAs("OnSlice")]
        public UnityEvent noteCut;

        [Tooltip("Triggered when combo changes, returns new combo")]
        [FormerlySerializedAs("OnComboChanged")]
        public ComboChangedEvent comboChanged = new();

        [Tooltip("Triggered when accuracy changes, returns percentage accuracy between 0 and 1")]
        [FormerlySerializedAs("OnAccuracyChanged")]
        public AccuracyChangedEvent accuracyChanged = new();

        [Tooltip("Triggered when combo is broken")]
        [FormerlySerializedAs("OnComboBreak")]
        public UnityEvent comboBroken;

        [Tooltip("Triggered when score multiplier increases")]
        [FormerlySerializedAs("MultiplierUp")]
        public UnityEvent multiplierUp;

        [Tooltip("Triggered when both sabers intersect")]
        [FormerlySerializedAs("SaberStartColliding")]
        public UnityEvent saberStartColliding;

        [Tooltip("Triggered when both sabers stop intersecting")]
        [FormerlySerializedAs("SaberStopColliding")]
        public UnityEvent saberStopColliding;

        [Tooltip("Triggered as soon as the song starts")]
        [FormerlySerializedAs("OnLevelStart")]
        public UnityEvent levelStarted;

        [Tooltip("Triggered when the last note of the map reaches the player")]
        [FormerlySerializedAs("OnLevelEnded")]
        public UnityEvent levelEnded;

        [Tooltip("Triggered when the player runs out of energy/life")]
        [FormerlySerializedAs("OnLevelFail")]
        public UnityEvent levelFailed;

        [Tooltip("Triggered when one or more arcs start interacting with the saber")]
        public UnityEvent arcStartedInteracting;

        [Tooltip("Triggered when no more arcs are interacting with the saber")]
        public UnityEvent arcStoppedInteracting;

        [Tooltip("Triggered when environment boost colors toggle on or off")]
        public BoostColorsToggledEvent boostColorsToggled;
    }
}
