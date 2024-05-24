using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    [CreateAssetMenu(fileName = "PlayerSettings" , menuName = "Showcase/PlayerModule/PlayerSettings", order = 0)]
    public class PlayerSettings : ScriptableObject
    {
        public float Speed;
    }
}
