using UnityEngine;

namespace MADLEngine
{
    public class BasicModule : MonoBehaviour, IModule
    {
        [SerializeField] private BasicLinks _links;
        [SerializeField] private BasicData _data;
        internal Actions _actions;

        public ILinks Links
        {
            get { return _links; }
            set { _links = (BasicLinks)value; }
        }

        public IData Data => _data;
        public IActions Actions => _actions;

        public virtual void Initialise()
        {
            _actions = new Actions();
            _links.InitialiseLinks();
        }
    }
}

