using UnityEngine;

namespace CADLEngine
{
    public class BasicModule : MonoBehaviour, IModule
    {
        [SerializeField] private BasicLinks _links;
        [SerializeField] private BasicData _data;
        internal Actions _actions;

        public ILinks Links => _links;
        public IData Data => _data;
        public IActions Actions => _actions;

        public virtual void Initialise()
        {
            _actions = new Actions();
        }
    }
}

