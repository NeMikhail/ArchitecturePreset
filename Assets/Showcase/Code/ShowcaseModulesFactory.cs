using MADLEngine;
using UnityEngine;

namespace Showcase.Code
{
    public class ShowcaseModulesFactory : ModulesFactory
    {
        private void Start()
        {
            //DebugShowcase();
        }
    
        private void DebugShowcase()
        {
            Debug.Log("Showcase Modules factory");
            Debug.Log("Modules list : ");
            foreach (IModule module in Modules)
            {
                Debug.Log(module);
                
                if (module.Actions.ActionsList.Count != 0)
                {
                    Debug.Log("Actions : ");
                    foreach (IAction action in module.Actions.ActionsList)
                    {
                        Debug.Log(action);
                    }
                }
                else
                {
                    Debug.Log("No actions");
                }
    
                if (module.Data != null)
                {
                    if (module.Data.DataScriptables.Count != 0)
                    {
                        Debug.Log("Data : ");
                        foreach (ScriptableObject data in module.Data.DataScriptables)
                        {
                            Debug.Log(data);
                        }
                    }
                    else
                    {
                        Debug.Log("No data");
                    }
                }
                else
                {
                    Debug.Log("No data");
                }
    
    
                if (module.Links != null)
                {
                    if (module.Links.SceneObjects.Count != 0)
                    {
                        Debug.Log("Links : ");
                        foreach (GameObject scrneObject in module.Links.SceneObjects)
                        {
                            Debug.Log(scrneObject);
                        }
                    }
                    else
                    {
                        Debug.Log("No links");
                    }
                }
                else
                {
                    Debug.Log("No links");
                }
            }
        }
    }

}

