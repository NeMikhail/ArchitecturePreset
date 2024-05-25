using Showcase.Code.Enum;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    [CreateAssetMenu(fileName = "PlayerDataContainer" , menuName = "Showcase/PlayerModule/PlayerDataContainer", order = 0)]
    public class PlayerDataContainer : ScriptableObject
    {
        public Direction MovementDirection;
    }
}