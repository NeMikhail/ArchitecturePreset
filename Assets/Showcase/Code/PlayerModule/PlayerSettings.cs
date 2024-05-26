using Assets.Showcase.Code.ShootingModule;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    [CreateAssetMenu(fileName = "PlayerSettings" , menuName = "Showcase/PlayerModule/PlayerSettings", order = 0)]
    public class PlayerSettings : ScriptableObject
    {
        public GameObject PlayerPrefab;
        public float Speed;
        public BulletConfiguration StartBulletConfiguration;
    }
}
