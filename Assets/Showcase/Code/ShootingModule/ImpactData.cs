using System;
using Showcase.Code.Enum;
using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    [Serializable]
    public class ImpactData
    {
        public Vector2 ImpactPosition;
        public bool IsWallImpacted;
        public BulletData BulletData;

        public ImpactData(Vector2 impactPosition, BulletData bulletData)
        {
            ImpactPosition = impactPosition;
            BulletData = bulletData;
        }

        public Vector2Int GetImpactedTilePosition()
        {
            Direction direction = BulletData.Direction;
            Vector2 position = Vector2.zero;
            Vector2Int roundedPosition = new Vector2Int();
            
            switch (direction)
            {
                case Direction.Up:
                    position = new Vector2(ImpactPosition.x, ImpactPosition.y);
                    roundedPosition = new Vector2Int(
                        (int)Math.Ceiling(position.x) - 1,
                        (int)Math.Round(position.y));
                    break;
                case Direction.Down:
                    position = new Vector2(ImpactPosition.x, ImpactPosition.y);
                    roundedPosition = new Vector2Int(
                        (int)Math.Ceiling(position.x) - 1, 
                        (int)Math.Round(position.y - 0.1f) - 1);
                    break;
                case Direction.Left:
                    position = new Vector2(ImpactPosition.x, ImpactPosition.y);
                    roundedPosition = new Vector2Int(
                        (int)Math.Round(position.x - 0.1f) - 1,
                        (int)Math.Ceiling(position.y) - 1);
                    break;
                case Direction.Right:
                    position = new Vector2(ImpactPosition.x, ImpactPosition.y);
                    roundedPosition = new Vector2Int(
                        (int)Math.Round(position.x),
                        (int)Math.Ceiling(position.y) - 1);
                    break;
            }
            Debug.Log($"{roundedPosition.x} {roundedPosition.y}");
            return roundedPosition;
        }
    }
}