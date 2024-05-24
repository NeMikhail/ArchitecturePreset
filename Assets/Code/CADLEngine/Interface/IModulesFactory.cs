using System.Collections.Generic;

namespace CADLEngine
{
    public interface IModulesFactory
    {
        public List<IModule> GetModulesList();
    }
}