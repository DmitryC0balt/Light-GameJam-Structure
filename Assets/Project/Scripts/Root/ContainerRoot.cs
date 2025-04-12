using Scripts.Container;
using Scripts.ScriptableObjects.ContainerConfig;

using UnityEngine;

namespace Scripts.Root
{
    public class ContainerRoot : MonoBehaviour
    {
        public UIContainer uiContainer{ get; private set;}
        public SceneContainer sceneContainer{ get; private set;}

        private bool _isLoaded = false;


        public void LoadContainer(ContainerConfigSO containerConfig)
        {
            uiContainer = containerConfig.uiContainer;
            sceneContainer = containerConfig.sceneContainer;
        }


        private void Update()
        {
            if (!_isLoaded) return;
        }


        private void FixedUpdate()
        {
            if (!_isLoaded) return;
        }


        private void LateUpdate()
        {
            if (!_isLoaded) return;
        }
    }
}