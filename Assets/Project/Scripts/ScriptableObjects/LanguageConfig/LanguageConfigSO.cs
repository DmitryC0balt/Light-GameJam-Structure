using UnityEngine;

namespace Scripts.ScriptableObjects.LanguageConfig
{
    public class LanguageConfigSO : ScriptableObject
    {
        [SerializeField]private string _configName;

        public string configName => _configName;
    }
}