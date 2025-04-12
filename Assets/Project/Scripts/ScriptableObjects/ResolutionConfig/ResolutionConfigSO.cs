using UnityEngine;

namespace Scripts.ScriptableObjects.DisplayConfig
{
    [CreateAssetMenu(fileName = "ResolutionConfig",menuName = "ScriptableObjects/ResolutionConfig",order = 3)]
    public class ResolutionConfigSO : ScriptableObject
    {
        [SerializeField]private string _configName;
        [SerializeField]private int _width;
        [SerializeField]private int _height;

        public string configName => _configName;
        public int width => _width;
        public int height => _height;
    }
}