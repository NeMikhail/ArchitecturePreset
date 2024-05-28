using System.Collections.Generic;
using MADLEngine;
using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    public class ShootingData : BasicData
    {
        public List<ShootingDataContainer> GetEnemyShootingDataContainers()
        {
            return GetDataObjectOfType<ShootersDataContainersList>().EnemyShootingDataList;
        }

        public ShootingDataContainer GetPlayerShootingData()
        {
            return GetDataObjectOfType<ShootersDataContainersList>().PlayerShootingData;
        }
    }
}