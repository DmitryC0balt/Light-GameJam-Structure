using Scripts.Container;
using UnityEngine;

namespace Scripts.ScriptableObjects.ContainerConfig
{
    [CreateAssetMenu(fileName = "ContainerConfig",menuName = "ScriptableObjects/ContainerConfigFile",order = 2)]
    public class ContainerConfigSO : ScriptableObject
    {
        [SerializeField]private string _configName;
        [SerializeField]private SceneContainer _sceneContainer;
        [SerializeField]private UIContainer _uiContainer;

        public string configName => _configName;
        public SceneContainer sceneContainer => _sceneContainer;
        public UIContainer uiContainer => _uiContainer;
    }
}