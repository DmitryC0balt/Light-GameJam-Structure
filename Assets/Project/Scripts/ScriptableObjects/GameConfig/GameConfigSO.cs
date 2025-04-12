using Scripts.ScriptableObjects.ContainerConfig;
using Scripts.ScriptableObjects.DisplayConfig;
using Scripts.ScriptableObjects.LanguageConfig;

using UnityEngine;

namespace Scripts.ScriptableObjects.GameConfig
{
    [CreateAssetMenu(fileName = "GameConfigFile", menuName = "ScriptableObjects/GameConfigFile", order = 0)]
    public class GameConfigSO : ScriptableObject
    {
        [Header("Containers")]
        [SerializeField]private ContainerConfigSO[] _containerConfigs;
        public ContainerConfigSO[] containerConfigs => _containerConfigs;

        [Space(10),Header("Resolutions")]
        [SerializeField]private ResolutionConfigSO[] _resolutionConfigs;
        public ResolutionConfigSO[] resolutionConfigs => _resolutionConfigs;

        [Space(10),Header("Languages")]
        [SerializeField]private LanguageConfigSO[] _languageConfigs;
        public LanguageConfigSO[] languageConfigs => _languageConfigs;
    }
}