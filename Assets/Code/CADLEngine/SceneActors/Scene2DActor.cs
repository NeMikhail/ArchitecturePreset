using System;
using UnityEngine;

namespace CADLEngine
{
    public class Scene2DActor : MonoBehaviour
    {
        public Action<Scene2DActor, Collider2D> TriggerEnter;
        public Action<Scene2DActor, Collider2D> TriggerExit;
        public Action<Scene2DActor, Collider2D> TriggerStay;
        public Action<Scene2DActor, Collision2D> CollisionEnter;
        public Action<Scene2DActor, Collision2D> CollisionExit;
        public Action<Scene2DActor, Collision2D> CollisionStay;
        public Action<Scene2DActor> BecameVisible;
        public Action<Scene2DActor> BecameInvisible;

        private void OnTriggerEnter2D(Collider2D other)
        {
            TriggerEnter?.Invoke(this, other);
        }
    
        private void OnTriggerExit2D(Collider2D other)
        {
            TriggerExit?.Invoke(this, other);
        }
    
        private void OnTriggerStay2D(Collider2D other)
        {
            TriggerStay?.Invoke(this, other);
        }
    
        private void OnCollisionEnter2D(Collision2D other)
        {
            CollisionEnter?.Invoke(this, other);
        }
    
        private void OnCollisionExit2D(Collision2D other)
        {
            CollisionExit?.Invoke(this, other);
        }
    
        private void OnCollisionStay2D(Collision2D other)
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