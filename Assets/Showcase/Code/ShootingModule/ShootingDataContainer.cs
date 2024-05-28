using System;
using Showcase.Code.Enum;
using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    [Serializable]
    public class ShootingDataContainer : IShootingDataContainer
    {
        [SerializeField] private bool _isShooting;
        [SerializeField] private BulletConfiguration _bulletConfiguration;
        [SerializeField] private Vector2 _bulletSpawnPosition;
        [SerializeField] private Direction _bulletDirection;
        
        public bool IsShooting
        {
            get => _isShooting;
            set => _isShooting = value;
        }

        public BulletConfiguration BulletConfiguration
        {
            get => _bulletConfiguration;
            set => _bulletConfiguration = value;
        }

        public Vector2 BulletSpawnPosition
        {
            get => _bulletSpawnPosition;
            set => _bulletSpawnPosition = value;
        }

        public Direction BulletDirection
        {
            get => _bulletDirection;
            set => _bulletDirection = value;
        }
    }
}