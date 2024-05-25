using System.Collections.Generic;
using UnityEngine;

namespace MADLEngine
{
    public class BasicData : MonoBehaviour, IData
    {
        [SerializeField] private List<ScriptableObject> _dataScriptables;
        private bool _isDebugMode;

        public List<ScriptableObject> DataScriptables => _dataScriptables;
        
        public void EnableDebugMode()
        {
            _isDebugMode = true;
        }

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

            if (_isDebugMode)
            {
                Debug.Log($"No object of type {typeof(T)} in dataObjects");
            }
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

            if (dataObjectsOfType.Count == 0 && _isDebugMode)
            {
                Debug.Log($"No objects of type {typeof(T)} in dataObjects");
            }
            return dataObjectsOfType;
        }
    }
}