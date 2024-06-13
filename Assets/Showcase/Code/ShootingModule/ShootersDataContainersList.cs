using System.Collections.Generic;
using MADLEngine.Extention;
using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    [CreateAssetMenu(fileName = "ShootersDataContainersList" , menuName = "Showcase/ShootingModule/ShootersDataContainersList", order = 0)]
    public class ShootersDataContainersList : ScriptableObject
    {
        public ShootingDataContainer PlayerShootingData;
        public List<ShootingDataContainer> EnemyShootingDataList;
    }
}