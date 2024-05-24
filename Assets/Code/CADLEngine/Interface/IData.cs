using System.Collections.Generic;
using UnityEngine;

namespace CADLEngine
{
    public interface IData
    {
        public List<ScriptableObject> DataScriptables { get; }
        
        public T GetDataObjectOfType<T>() where T : ScriptableObject;
        public List<T> GetDataObjectsOfType<T>() where T : ScriptableObject;

    }
}