using System.Collections.Generic;
using UnityEngine;

namespace MADLEngine
{
    public interface ILinks
    {
        public List<GameObject> SceneObjects { get; }

        public void InitialiseLinks();
        public void EnableDebugMode();
        public List<GameObject> GetObjectsWithComponent<T>() where T : Component;
        public GameObject GetObjectWithComponent<T>() where T : Component;
        public List<T> GetComponentsFromObjectsList<T>() where T : Component;
        public T GetComponentFromObjectsList<T>() where T : Component;
        public T GetComponentInChildsFromObjectsList<T>() where T : Component;
        public List<T> GetComponentsInChildsFromObjectsList<T>() where T : Component;

    }
}