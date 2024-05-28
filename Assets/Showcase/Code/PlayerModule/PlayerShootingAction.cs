using Assets.Showcase.Code.ShootingModule;
using MADLEngine;
using MADLEngine.Extention;
using Showcase.Code.Enum;
using Showcase.Code.InputModule;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    public class PlayerShootingAction : IAction, IInitialisation, IExecute, IFixedExecute
    {
        private InputContainer _input;
        private ShootersDataContainersList _shootersDataContainersList;
        private PlayerSettings _playerSettings;
        private PlayerDataContainer _playerData;
        private PlayerLinks _playerLinks;
        private BulletConfiguration _currentBulletConfiguration;
        private bool _onCooldown;
        private Timer _timer;
        
        public PlayerShootingAction(InputContainer input, ShootersDataContainersList shootersDataContainersList,
            PlayerSettings playerSettings, PlayerDataContainer playerData,
            PlayerLinks playerLinks)
        {
            _input = input;
            _shootersDataContainersList = shootersDataContainersList;
            _playerSettings = playerSettings;
            _playerData = playerData;
            _playerLinks = playerLinks;
            _timer = new Timer();
        }
        
        public void Initialisation()
        {
            _currentBulletConfiguration = _playerSettings.StartBulletConfiguration;
            _playerData.ShootingCooldown = _playerSettings.BasicShootingCooldown;
        }
        
        public void Execute(float deltaTime)
        {
            if (_input.WasLeftMouseButtonDown && !_shootersDataContainersList.PlayerShootingData.IsShooting &&
                !_onCooldown)
            {
                ShootingDataContainer playerShootingData = new ShootingDataContainer();
                playerShootingData.BulletConfiguration = _currentBulletConfiguration;
                if (_playerData.MovementDirection != Direction.None)
                {
                    playerShootingData.BulletDirection = _playerData.MovementDirection;
                }
                playerShootingData.BulletSpawnPosition = _playerLinks.GetCurrentBulletSpawnPosition();
                playerShootingData.IsShooting = true;
                _shootersDataContainersList.PlayerShootingData = playerShootingData;
                _onCooldown = true;
            }
        }


        public void FixedExecute(float fixedDeltaTime)
        {
            if (_onCooldown)
            {
                if (_timer.IsWaiting)
                {
                    if (_timer.Wait())
                    {
                        _onCooldown = false;
                    }
                    else
                    {
                        //Debug.Log(_timer.GetRoundedRemainingTime(2));
                    }
                }
                else
                {
                    _timer = new Timer(_playerData.ShootingCooldown);
                }
            }
        }
    }
}