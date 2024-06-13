using System.Collections.Generic;

namespace MADLEngine
{
    public interface IModulesFactory
    {
        public List<IModule> GetModulesList();
    }
}