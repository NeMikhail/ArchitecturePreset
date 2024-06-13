using System.Collections.Generic;
using UnityEngine;

namespace MADLEngine
{
    public interface IData
    {
        public List<ScriptableObject> DataScriptables { get; }
        public void EnableDebugMode();
        public T GetDataObjectOfType<T>() where T : ScriptableObject;
        public List<T> GetDataObjectsOfType<T>() where T : ScriptableObject;

    }
}