using MADLEngine;
using Showcase.Code.Enum;
using Showcase.Code.InputModule;

namespace Showcase.Code.PlayerModule
{
    public class PlayerShootingAction : IAction, IInitialisation, IExecute
    {
        private InputContainer _input;
        private PlayerDataContainer _playerData;
        private PlayerSettings _playerSettings;
        private PlayerLinks _playerLinks;
        
        public PlayerShootingAction(InputContainer input, PlayerDataContainer playerData, PlayerSettings playerSettings,
            PlayerLinks playerLinks)
        {
            _input = input;
            _playerData = playerData;
            _playerSettings = playerSettings;
            _playerLinks = playerLinks;
        }
        
        public void Initialisation()
        {
            _playerData.BulletConfiguration = _playerSettings.StartBulletConfiguration;
        }
        
        public void Execute(float deltaTime)
        {
            if (_input.WasLeftMouseButtonDown)
            {
                if (_playerData.MovementDirection != Direction.None)
                {
                    _playerData.BulletDirection = _playerData.MovementDirection;
                }
                _playerData.BulletSpawnPosition = _playerLinks.GetCurrentBulletSpawnPosition();
                _playerData.IsShooting = true;
            }
        }
    }
}