using Assets.Showcase.Code.LocationModule;
using MADLEngine;
using MADLEngine.Extention;
using Showcase.Code.Enum;
using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    public class BulletsAction : IAction, IInitialisation, IFixedExecute
    {
        private BulletsData _bulletsData;
        private BulletsImpactData _bulletsImpactData;

        public BulletsAction(BulletsData bulletsData, BulletsImpactData bulletsImpactData)
        {
            _bulletsData = bulletsData;
            _bulletsImpactData = bulletsImpactData;
        }
        
        public void Initialisation()
        {
            _bulletsData.OnBulletAdded += AddBullet;
        }
        
        public void FixedExecute(float fixedDeltaTime)
        {
            MoveBullets();
        }

        private void MoveBullets()
        {
            foreach (DictionaryElement<Scene2DActor, BulletData> bullet  in _bulletsData.BulletsList.Dictionary)
            {
                Direction direction = bullet.Value.Direction;
                Vector2 movementVector = new Vector2();
                switch (direction)
                {
                    case Direction.Up:
                        movementVector = Vector2.up;
                        break;
                    case Direction.Down:
                        movementVector = Vector2.down;
                        break;
                    case Direction.Left:
                        movementVector = Vector2.left;
                        break;
                    case Direction.Right:
                        movementVector = Vector2.right;
                        break;
                }
                bullet.Key.Rigidbody.velocity = movementVector * bullet.Value.Speed;
            }
        }

        private void AddBullet(Scene2DActor bulletActor)
        {
            bulletActor.CollisionEnter += ImpactBullet;
        }

        private void ImpactBullet(Scene2DActor scene2DActor, Collision2D collided)
        {
            BulletData bulletConfiguration = _bulletsData.BulletsList.GetValue(scene2DActor);
            ImpactData impact = new ImpactData(scene2DActor.GetPosition(), bulletConfiguration);
            string collidedObjectTag = collided.gameObject.tag;
            if (collidedObjectTag == LocationConstants.WALLS_TAG)
            {
                impact.IsWallImpacted = true;
            }
            _bulletsImpactData.ImpactDataList.Add(impact);
            _bulletsData.RemoveBullet(scene2DActor);
            scene2DActor.Destroy();
        }
    }
}