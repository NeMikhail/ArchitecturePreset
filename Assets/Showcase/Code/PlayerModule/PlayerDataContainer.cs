using Assets.Showcase.Code.ShootingModule;
using Showcase.Code.Enum;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    [CreateAssetMenu(fileName = "PlayerDataContainer" , menuName = "Showcase/PlayerModule/PlayerDataContainer", order = 0)]
    public class PlayerDataContainer : ScriptableObject
    {
        public Direction MovementDirection;
        public Vector2 StartPosition;
        public bool IsLocationChanged;
        public float ShootingCooldown;
    }
}