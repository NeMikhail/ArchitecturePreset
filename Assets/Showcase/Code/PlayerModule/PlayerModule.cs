using MADLEngine;
using Showcase.Code.InputModule;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    public class PlayerModule : BasicModule
    {
        private InputContainer _input;
        private PlayerSettings _playerSettings;
        private PlayerDataContainer _playerData;
        
        public override void Initialise()
        {
            InitializeFields();
            InitialisePlayerSpawn();
            InitialisePlayerMovement();
        }

        private void InitializeFields()
        {
            _actions = new Actions();
            Links.InitialiseLinks();
            _input = Data.GetDataObjectOfType<InputContainer>();
            _playerSettings = Data.GetDataObjectOfType<PlayerSettings>();
            _playerData = Data.GetDataObjectOfType<PlayerDataContainer>();

        }

        private void InitialisePlayerSpawn()
        {
            PlayerSpawnAndPositionChangeAction playerSpawnAndPositionChangeAction =
                new PlayerSpawnAndPositionChangeAction(_playerSettings, _playerData, Links);
            _actions.Add(playerSpawnAndPositionChangeAction);
        }

        private void InitialisePlayerMovement()
        {
            PlayerMovementAction playerMovementAction = new PlayerMovementAction(
                _input, _playerSettings, Links, _playerData);
            _actions.Add(playerMovementAction);
        }
    }
}
