using CADLEngine;
using Showcase.Code.InputModule;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    public class PlayerMovementAction : IAction, IFixedExecute
    {
        private Rigidbody2D _playerRigidbody;
        private InputContainer _input;
        private float _speed;

        public PlayerMovementAction(InputContainer input, PlayerSettings playerSettings, ILinks links)
        {
            _playerRigidbody = links.GetComponentFromObjectsList<Rigidbody2D>();
            _input = input;
            _speed = playerSettings.Speed;

        }
    
        public void FixedExecute(float fixedDeltaTime)
        {
            Vector3 direction = new Vector3(_input.horizontalAxis, _input.verticalAxis, 0);
            _playerRigidbody.velocity = direction * _speed;
        }
    }
}
