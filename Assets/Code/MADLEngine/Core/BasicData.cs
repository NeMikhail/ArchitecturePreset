using System.Collections.Generic;
using UnityEngine;

namespace MADLEngine
{
    public class BasicData : MonoBehaviour, IData
    {
        [SerializeField] private List<ScriptableObject> _dataScriptables;

        public List<ScriptableObject> DataScriptables => _dataScriptables;

        public T GetDataObjectOfType<T>() where T : ScriptableObject
        {
            T dataObjectOfType = null;
            foreach (ScriptableObject dataObject in _dataScriptables)
            {
                if (dataObject.GetType() == typeof(T))
                {
                    dataObjectOfType = (T)dataObject;
                    return dataObjectOfType;
                }
            }
            Debug.Log($"No object of type {typeof(T)} in dataObjects");
            return dataObjectOfType;
        }
        
        public List<T> GetDataObjectsOfType<T>() where T : ScriptableObject
        {
            List<T> dataObjectsOfType = new List<T>();
            foreach (ScriptableObject dataObject in _dataScriptables)
            {
                if (dataObject.GetType() == typeof(T))
                {
                    dataObjectsOfType.Add((T)dataObject);
                }
            }

            if (dataObjectsOfType.Count == 0)
            {
                Debug.Log($"No objects of type {typeof(T)} in dataObjects");
            }
            return dataObjectsOfType;
        }
    }
}