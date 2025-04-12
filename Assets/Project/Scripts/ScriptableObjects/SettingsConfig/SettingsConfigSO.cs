using Scripts.ScriptableObjects.DisplayConfig;
using Scripts.ScriptableObjects.LanguageConfig;

using UnityEngine;

namespace Scripts.ScriptableObjects.SettingsConfig
{
    [CreateAssetMenu(fileName = "SettingsConfig", menuName = "ScriptableObjects/SettingsConfig", order = 0)]
    public class SettingsConfigSO : ScriptableObject
    {
        public bool isSaveMode{get; private set;}
        public bool isLoadMode{get; private set;}

        public LanguageConfigSO languageConfig{ get; private set;}
        public ResolutionConfigSO resolutionConfig{ get; private set;}

        public bool isWindowMode{get; private set;}

        public float sfxVolume{get; private set;}
        public float ambientVolume{get; private set;}
        public float musicVolume{get; private set;}

        public void LoadMode()
        {
            isLoadMode = true;
            isSaveMode = false;
        }


        public void SaveMode()
        {
            isSaveMode = true;
            isLoadMode = false;
        }


        public void SaveVolumeSettings(float sfxVolume,float ambientVolume,float musicVolume)
        {
            if (!isSaveMode) return;
            this.sfxVolume = sfxVolume;
            this.ambientVolume = ambientVolume;
            this.musicVolume = musicVolume;
        }


        public void SaveDisplaySettings(ResolutionConfigSO resolutionConfig,bool isWindowMode) 
        {
            if (!isSaveMode) return;
            this.resolutionConfig = resolutionConfig;
            this.isWindowMode = isWindowMode;
        }


        public void SaveLanguageSettings(LanguageConfigSO languageConfig)
        {
            if (!isSaveMode) return;
            this.languageConfig = languageConfig;
        }
    }
}