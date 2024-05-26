using System.Collections.Generic;
using MADLEngine;
using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    public class ShootingData : BasicData
    {
        public List<IShootingDataContainer> GetShootingDataContainers()
        {
            List<IShootingDataContainer> shootingDataContainers = new List<IShootingDataContainer>();
            List<ScriptableObject> dataObjects = GetDataObjectsOfInterface<IShootingDataContainer>();
            foreach (ScriptableObject dataObject in dataObjects)
            {
                shootingDataContainers.Add((IShootingDataContainer)dataObject);
                Debug.Log(shootingDataContainers[shootingDataContainers.Count - 1]);
            }
            return shootingDataContainers;
        }
    }
}