using Assets.Showcase.Code.ShootingModule;
using MADLEngine;
using Showcase.Code.InputModule;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    public class PlayerModule : BasicModule
    {
        public SpawnedObjectsLinks SpawnedObjectsLinks;
        
        private InputContainer _input;
        private PlayerSettings _playerSettings;
        private PlayerDataContainer _playerData;
        private PlayerLinks _playerLinks;
        private ShootersDataContainersList _shootersDataContainersList;
        
        public override void Initialise()
        {
            InitializeFields();
            InitialisePlayerSpawn();
            InitialisePlayerMovement();
            InitialisePlayerShooting();
        }
        
        private void InitializeFields()
        {
            _actions = new Actions();
            Links.InitialiseLinks();
            _playerLinks = (PlayerLinks)Links;
            _input = Data.GetDataObjectOfType<InputContainer>();
            _playerSettings = Data.GetDataObjectOfType<PlayerSettings>();
            _playerData = Data.GetDataObjectOfType<PlayerDataContainer>();
            _shootersDataContainersList = Data.GetDataObjectOfType<ShootersDataContainersList>();

        }

        private void InitialisePlayerSpawn()
        {
            PlayerSpawnAndPositionChangeAction playerSpawnAndPositionChangeAction =
                new PlayerSpawnAndPositionChangeAction(_playerSettings, _playerData, Links, SpawnedObjectsLinks);
            _actions.Add(playerSpawnAndPositionChangeAction);
        }

        private void InitialisePlayerMovement()
        {
            PlayerMovementAction playerMovementAction = new PlayerMovementAction(
                _input, _playerSettings, Links, _playerData);
            _actions.Add(playerMovementAction);
        }
        
        private void InitialisePlayerShooting()
        {
            PlayerShootingAction playerShootingAction = new PlayerShootingAction(_input, _shootersDataContainersList,
                _playerSettings, _playerData, _playerLinks);
            _actions.Add(playerShootingAction);
        }
    }
}
