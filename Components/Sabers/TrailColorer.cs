using AssetComponents.Models;
using UnityEngine;

#pragma warning disable CS0649

namespace AssetComponents.Components.Sabers
{
    [AddComponentMenu("Beat Saber/AssetComponents/TrailColorer")]
    [RequireComponent(typeof(CustomTrail))]
    public class TrailColorer : MonoBehaviour, IColorer
    { 
        private MaterialPropertyBlock materialPropertyBlock;
        
        [SerializeField]
        [Tooltip("The colorer will target the materials of this Mesh Renderer")]
        private CustomTrail customTrail;
        
        [Space]
        
        [SerializeField]
        [Tooltip("Array index of the material from the Mesh Renderer should be colored")]
        private int materialIndex;
        
        [SerializeField]
        [Tooltip("The name of the target color property of the trail material")]
        private string propertyName = "_Color";
        
        [SerializeField]
        [Tooltip("Which color from a color scheme should be given")]
        private ColorSchemeType colorSchemeType;
        
        [SerializeField]
        [Tooltip("When Color Type is set to an environment color, toggle between normal and boost colors on boost event")]
        private bool useColorBoostEvents;

        [SerializeField]
        [Tooltip("Whether to use this color for the vertex colors of the trail's mesh")]
        private bool applyToVertexColor;
        
        [SerializeField]
        [Tooltip("The color given to the property is always multiplied by the multiplier color; white has no effect")]
        private Color multiplierColor = Color.white;

        public Material Material => customTrail.materials[materialIndex];
        public MaterialPropertyBlock MaterialPropertyBlock => materialPropertyBlock ??= new();
        
        public string PropertyName => propertyName;
        public ColorSchemeType ColorSchemeType => colorSchemeType;
        public bool UseColorBoostEvents => useColorBoostEvents;
        public bool ApplyToVertexColor => applyToVertexColor;
        public Color MultiplierColor => multiplierColor;
    }
}