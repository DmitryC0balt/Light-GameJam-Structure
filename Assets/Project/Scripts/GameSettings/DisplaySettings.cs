using Scripts.ScriptableObjects.GameConfig;
using Scripts.ScriptableObjects.SettingsConfig;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.GameSettings
{
    public class DisplaySettings : MonoBehaviour
    {
        [Header("Canvas")]
        [SerializeField]private Canvas _canvas;

        [Space(10),Header("UI")]
        [SerializeField]private Dropdown _resolutionDropDown;
        [SerializeField]private Dropdown _qualityDropDown;

        [SerializeField]private Toggle _isWindowToggle;


        public void Initialization(GameConfigSO gameConfig)
        {
            _resolutionDropDown.ClearOptions();
            
            
        }


        public void LoadSettings(SettingsConfigSO settingsConfig)
        {
            
        }


        public void SaveSettings(SettingsConfigSO settingsConfig)
        {

        }
    }
}