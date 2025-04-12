using Scripts.Root;

using UnityEngine;

namespace Scripts.Container
{
    public abstract class UIContainer : MonoBehaviour
    {
        public abstract void OnInitialization(ContainerRoot containerRoot);
        public abstract void OnDispose(ContainerRoot containerRoot);

        public virtual void OnProcess() {}
    }
}