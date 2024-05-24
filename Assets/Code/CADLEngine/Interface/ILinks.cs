using System.Collections.Generic;
using UnityEngine;

namespace CADLEngine
{
    public interface ILinks
    {
        public List<GameObject> SceneObjects { get; }

        public List<GameObject> GetObjectsWithComponent<T>() where T : Component;
        public GameObject GetObjectWithComponent<T>() where T : Component;
        public List<T> GetComponentsFromObjectsList<T>() where T : Component;
        public T GetComponentFromObjectsList<T>() where T : Component;

    }
}