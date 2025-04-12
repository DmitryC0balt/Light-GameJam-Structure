using UnityEngine;

namespace Scripts.Root
{
    public class GameRoot : MonoBehaviour
    {
        private ContainerRoot _containerRoot;
        private AudioRoot _audioRoot;

        [SerializeField]private GameObject _loadingScreen;

        public void Initialization()
        {
            _containerRoot = GetComponent<ContainerRoot>();
            _audioRoot = GetComponent<AudioRoot>();
        }
    }
}