using Scripts.ScriptableObjects.SettingsConfig;

using UnityEngine;
using UnityEngine.UI;

namespace Scripts.GameSettings
{
    public class SettingsMenu : MonoBehaviour
    {
        [Header("Buttons")]
        [SerializeField]private Button _volumeSettingsButton;
        [SerializeField]private Button _displaySettingsButton;
        [SerializeField]private Button _languageSettingsButton;

        [Header("Settings")]
        [SerializeField]private AudioSettings _audioSettings;
        [SerializeField]private DisplaySettings _displaySettings;
        [SerializeField]private LanguageSettings _languageSettings;

        [Header("Settings file")]
        [SerializeField]private SettingsConfigSO _settingsConfig;
        private DefaultGameSettings _defaultGameSettings;

        private GameObject _currentScreen;
        
        private void SetButtonActivity(Button button, bool value) => button.gameObject.SetActive(value);

        public void SetVolumeButton(bool value) => SetButtonActivity(_volumeSettingsButton,value);
        public void SetDisplayButton(bool value) => SetButtonActivity(_displaySettingsButton,value);
        public void SetLanguageButton(bool value) => SetButtonActivity(_languageSettingsButton,value);


        void OnEnable()
        {
            Initialization();
        }


        public void Initialization()
        {
            //LoadSettings();
            HideAllScreens();
            ShowVolumeScreen();
        }


        private void HideAllScreens()
        {
            _audioSettings.gameObject.SetActive(false);
            _displaySettings.gameObject.SetActive(false);
            _languageSettings.gameObject.SetActive(false);
        }


        private void ShowScreen(GameObject settingsScreen)
        {
            _currentScreen?.SetActive(false);
            _currentScreen = settingsScreen;
            _currentScreen.SetActive(true);
        }


        private void LoadSettings()
        {
            _audioSettings.LoadSettings(_settingsConfig);
            _displaySettings.LoadSettings(_settingsConfig);
            _languageSettings.LoadSettings(_settingsConfig);
        }


        public void SaveSettings()
        {
        
            gameObject.SetActive(false);
        }


        public void ResetSettings()
        {
            //Запись заводских настроек в файл
            //Сохранение файла
            LoadSettings();
        }


        public void ShowVolumeScreen() => ShowScreen(_audioSettings.gameObject);
        public void ShowDisplayScreen() => ShowScreen(_displaySettings.gameObject);
        public void ShowLanguageScreen() => ShowScreen(_languageSettings.gameObject);
    }
}

