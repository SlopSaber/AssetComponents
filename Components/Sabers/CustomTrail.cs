using UnityEngine;

namespace AssetComponents.Components.Sabers
{
    [AddComponentMenu("Beat Saber/CustomSabers/Custom Trail")]
    public class CustomTrail : MonoBehaviour
    {
        public Transform top;
        public Transform bottom;
        
        [Space]
        public Material[] materials;
        
        [Space]
        [Range(0, 1), Tooltip("Duration of the furthest section of the trail in seconds")]
        public float length = 0.4f;
        
        [Space] 
        [Tooltip("If not using a trail colorer, this color will always be used")]
        public Color trailColor = Color.white;
        [Tooltip("The color given to the trail is always multiplied by the multiplier color; white has no effect")]
        public Color multiplierColor = Color.white;
    }
}