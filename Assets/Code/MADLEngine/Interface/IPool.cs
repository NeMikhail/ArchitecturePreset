using UnityEngine;

namespace MADLEngine
{
    public interface IPool
    {
        public GameObject Pop(Vector3 position, Quaternion rotation);
        public void Push(GameObject go);
    }

}
