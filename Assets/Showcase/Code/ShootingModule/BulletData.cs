using Showcase.Code.Enum;

namespace Assets.Showcase.Code.ShootingModule
{
    public class BulletData
    {
        public int Power;
        public float Speed;
        public Direction Direction;

        public BulletData(int power, float speed, Direction direction)
        {
            Power = power;
            Speed = speed;
            Direction = direction;
        }
    }
}