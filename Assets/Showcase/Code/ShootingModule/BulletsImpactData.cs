using System.Collections.Generic;
using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    [CreateAssetMenu(fileName = "BulletsImpactData" , menuName = "Showcase/ShootingModule/BulletsImpactData", order = 1)]
    public class BulletsImpactData : ScriptableObject
    {
        public List<ImpactData> ImpactDataList;

        public ImpactData GetAndRemoveWallImpactData()
        {
            foreach (ImpactData impactData in ImpactDataList)
            {
                if (impactData.IsWallImpacted)
                {
                    ImpactDataList.Remove(impactData);
                    return impactData;
                }
            }

            return null;
        }
    }
}
