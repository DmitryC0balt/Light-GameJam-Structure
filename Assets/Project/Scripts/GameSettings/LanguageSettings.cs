using Scripts.ScriptableObjects.SettingsConfig;

using UnityEngine;
using UnityEngine.UI;

namespace Scripts.GameSettings
{
    public class LanguageSettings : MonoBehaviour
    {
        [SerializeField]private Dropdown _languageDropDown;


        public void LoadSettings(SettingsConfigSO settingsConfig)
        {

        }


        public void SaveSettings(SettingsConfigSO settingsConfig)
        {

        }
    }
}