using System;
using SaberComponents.Models;
using UnityEngine;

#pragma warning disable CS0649

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/SaberComponents/MaterialColorer")]
    [RequireComponent(typeof(MeshRenderer))]
    public class MaterialColorer : MonoBehaviour
    {
        public MeshRenderer meshRenderer;
        
        [Space]
        public string propertyName;
        [Tooltip("Which color from a color scheme should be given")]
        public ColorSchemeType colorSchemeType;
        [Tooltip("When Color Type is set to an environment color, toggle between normal and boost colors on boost event")]
        public bool useColorBoostEvents;
        [Tooltip("The color given to the property is always multiplied by the multiplier color; white has no effect")]
        public Color multiplierColor;
        
        [HideInInspector] public MaterialPropertyBlock materialPropertyBlock;
    }
}
