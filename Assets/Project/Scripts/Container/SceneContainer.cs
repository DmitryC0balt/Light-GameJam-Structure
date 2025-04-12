using Scripts.Root;

using UnityEngine;

namespace Scripts.Container
{
    public abstract class SceneContainer : MonoBehaviour
    {
        public abstract void OnInitialization(ContainerRoot containerRoot);
        public abstract void OnDispose(ContainerRoot containerRoot);

        public virtual void OnProcess() {}
        public virtual void OnFixedProcess() {}
        public virtual void OnPostProcess() {}
    }
}