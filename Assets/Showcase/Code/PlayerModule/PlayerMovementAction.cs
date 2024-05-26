using System;
using MADLEngine;
using Showcase.Code.Enum;
using Showcase.Code.InputModule;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    public class PlayerMovementAction : IAction, IInitialisation, IFixedExecute
    {
        private ILinks _links;
        private Rigidbody2D _playerRigidbody;
        private GameObject _playerObject;
        private InputContainer _input;
        private PlayerDataContainer _playerData;
        private float _speed;
        private bool _isMoving;

        public PlayerMovementAction(InputContainer input, PlayerSettings playerSettings,
            ILinks links, PlayerDataContainer playerData)
        {
            _links = links;
            _input = input;
            _playerData = playerData;
            _speed = playerSettings.Speed;
        }
        
        public void Initialisation()
        {
            _playerRigidbody = _links.GetComponentInChildsFromObjectsList<Rigidbody2D>();
            _playerObject = _playerRigidbody.gameObject;
        }
    
        public void FixedExecute(float fixedDeltaTime)
        {
            Vector3 direction = new Vector3(_input.HorizontalAxis, _input.VerticalAxis, 0);
            _playerData.MovementDirection = GetMovementDirection();
            if (_isMoving)
            {
                RotateAndMovePlayer(_playerData.MovementDirection);
                _isMoving = false;
            }
            else
            {
                _playerRigidbody.velocity = Vector3.zero * _speed;
            }
        }

        private Direction GetMovementDirection()
        {
            float x = _input.HorizontalAxis;
            float y = _input.VerticalAxis;
            if (x != 0 || y != 0)
            {
                _isMoving = true;
                if (Math.Abs(x) > Math.Abs(y))
                {
                    if (x > 0)
                    {
                        return Direction.Right;
                    }
                    else
                    {
                        return Direction.Left;
                    }
                }
                else
                {
                    if (y > 0)
                    {
                        return Direction.Up;
                    }
                    else
                    {
                        return Direction.Down;
                    }
                }
            }
            else
            {
                return Direction.None;
            }

        }

        private void RotateAndMovePlayer(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left :
                    _playerObject.transform.eulerAngles = new Vector3(0, 0, 90);
                    _playerRigidbody.velocity = Vector3.left * _speed;
                    break;
                case Direction.Right :
                    _playerObject.transform.eulerAngles = new Vector3(0, 0, -90);
                    _playerRigidbody.velocity = Vector3.right * _speed;
                    break;
                case Direction.Up :
                    _playerObject.transform.eulerAngles = new Vector3(0, 0, 0);
                    _playerRigidbody.velocity = Vector3.up * _speed;
                    break;
                case Direction.Down :
                    _playerObject.transform.eulerAngles = new Vector3(0, 0, 180);
                    _playerRigidbody.velocity = Vector3.down * _speed;
                    break;
                default:
                    break;
            }
        }
    }
}
