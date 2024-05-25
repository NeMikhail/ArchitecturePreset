﻿using System.Collections.Generic;
using UnityEngine;

namespace MADLEngine
{
    public class BasicLinks : MonoBehaviour, ILinks
    {
        [SerializeField] private List<GameObject> _sceneObjects;
        private bool _isDebugMode;

        public List<GameObject> SceneObjects
        {
            get => _sceneObjects;
        }

        public virtual void InitialiseLinks()
        {
            
        }

        public void EnableDebugMode()
        {
            _isDebugMode = true;
        }

        public List<GameObject> GetObjectsWithComponent<T>() where T : Component
        {
            List<GameObject> objectsWithComponent = new List<GameObject>();
            foreach (GameObject sceneObject in _sceneObjects)
            {
                if (sceneObject.TryGetComponent<T>(out T component))
                {
                    objectsWithComponent.Add(sceneObject);
                }
            }

            if (objectsWithComponent.Count == 0 && _isDebugMode)
            {
                Debug.Log($"No objects with component {typeof(T)} in sceneLinks");
            }
            return objectsWithComponent;
        }

        public GameObject GetObjectWithComponent<T>() where T : Component
        {
            foreach (GameObject sceneObject in _sceneObjects)
            {
                if (sceneObject.TryGetComponent<T>(out T component))
                {
                    return sceneObject;
                }
            }

            if (_isDebugMode)
            {
                Debug.Log($"No object with component {typeof(T)} in sceneLinks");
            }
            return null;
        }
        
        public List<T> GetComponentsFromObjectsList<T>() where T : Component
        {
            List<T> componentsList = new List<T>();
            foreach (GameObject sceneObject in _sceneObjects)
            {
                if (sceneObject.TryGetComponent<T>(out T component))
                {
                    componentsList.Add(component);
                }
            }
            if (componentsList.Count == 0 && _isDebugMode)
            {
                Debug.Log($"No objects with component {typeof(T)} in sceneLinks");
            }
            return componentsList;
        }

        public T GetComponentFromObjectsList<T>() where T : Component
        {
            foreach (GameObject sceneObject in _sceneObjects)
            {
                if (sceneObject.TryGetComponent<T>(out T component))
                {
                    return component;
                }
            }

            if (_isDebugMode)
            {
                Debug.Log($"No object with component {typeof(T)} in sceneLinks");
            }
            return null;
        }
        
    }
}