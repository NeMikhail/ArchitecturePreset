using MADLEngine;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    public class PlayerSpawnAndPositionChangeAction : IAction, IInitialisation, IFixedExecute
    {
        private PlayerDataContainer _playerData;
        private ILinks _links;
        private GameObject _playerObjectPrefab;
        private GameObject _playerObject;
        private Transform _playerMovableObjectTransform;
        
        
        public PlayerSpawnAndPositionChangeAction(PlayerSettings playerSettings, PlayerDataContainer playerData,
            ILinks links)
        {
            _playerObjectPrefab = playerSettings.PlayerPrefab;
            _playerData = playerData;
            _links = links;
        }

        public void Initialisation()
        {
            SpawnPlayer();
            ChangePlayerPosition(_playerData.StartPosition);
        }
        
        public void FixedExecute(float fixedDeltaTime)
        {
            if (_playerData.IsLocationChanged)
            {
                Debug.Log(_playerData.IsLocationChanged);
                ChangePlayerPosition(_playerData.StartPosition);
                _playerData.IsLocationChanged = false;
            }
        }

        private void SpawnPlayer()
        {
            _playerObject = GameObject.Instantiate(_playerObjectPrefab);
            _links.SceneObjects.Add(_playerObject);
            _playerMovableObjectTransform = _playerObject.GetComponentInChildren<Rigidbody2D>().gameObject.transform;
        }

        private void ChangePlayerPosition(Vector2 position)
        {
            _playerObject.transform.position = position;
            _playerMovableObjectTransform.position = position;
            _playerMovableObjectTransform.eulerAngles = new Vector3(0, 0, 0);
        }
        
    }
}