using System;
using UnityEngine;

namespace CADLEngine
{
    public class Scene3DActor : MonoBehaviour
    {
        public Action<Scene3DActor, Collider> TriggerEnter;
        public Action<Scene3DActor, Collider> TriggerExit;
        public Action<Scene3DActor, Collider> TriggerStay;
        public Action<Scene3DActor, Collision> CollisionEnter;
        public Action<Scene3DActor, Collision> CollisionExit;
        public Action<Scene3DActor, Collision> CollisionStay;
        public Action<Scene3DActor> BecameVisible;
        public Action<Scene3DActor> BecameInvisible;
        
        private void OnTriggerEnter(Collider other)
        {
            TriggerEnter?.Invoke(this, other);
        }
    
        private void OnTriggerExit(Collider other)
        {
            TriggerExit?.Invoke(this, other);
        }
    
        private void OnTriggerStay(Collider other)
        {
            TriggerStay?.Invoke(this, other);
        }
    
        private void OnCollisionEnter(Collision other)
        {
            CollisionEnter?.Invoke(this, other);
        }
    
        private void OnCollisionExit(Collision other)
        {
            CollisionExit?.Invoke(this, other);
        }
    
        private void OnCollisionStay(Collision other)
        {
            CollisionStay?.Invoke(this, other);
        }
    
        private void OnBecameVisible()
        {
            BecameVisible?.Invoke(this);
        }
        
        private void OnBecameInvisible()
        {
            BecameInvisible?.Invoke(this);
        }
    
        private void OnDisable()
        {
            TriggerEnter = null;
            TriggerExit = null;
            TriggerStay = null;
            CollisionEnter = null;
            CollisionExit = null;
            CollisionStay = null;
            BecameVisible = null;
            BecameInvisible = null;
        }
    
    }
}

