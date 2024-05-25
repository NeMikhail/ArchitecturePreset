using System;
using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    [Serializable]
    public class ImpactData
    {
        public Vector2 ImpactPosition;
        public bool IsWallImpacted;
        public BulletConfiguration BulletConfiguration;

        public Vector2Int GetRoundedPosition()
        {
            Vector2Int roundedPosition = new Vector2Int(
                (int)Math.Round(ImpactPosition.x), (int)Math.Round(ImpactPosition.y));
            return roundedPosition;
        }
    }
}