using Showcase.Code.Enum;
using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    public interface IShootingDataContainer
    {
        public bool IsShooting { get; set; }
        public BulletConfiguration BulletConfiguration { get; set; }
        public Vector2 BulletSpawnPosition { get; set; }
        public Direction BulletDirection { get; set; }

    }
}