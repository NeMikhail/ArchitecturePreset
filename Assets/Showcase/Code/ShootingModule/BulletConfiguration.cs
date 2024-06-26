using UnityEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    [CreateAssetMenu(fileName = "BulletConfiguration" , menuName = "Showcase/ShootingModule/BulletConfiguration", order = 0)]
    public class BulletConfiguration : ScriptableObject
    {
        public GameObject BulletPrefab;
        public int Power;
        public float Speed;
    }
}
