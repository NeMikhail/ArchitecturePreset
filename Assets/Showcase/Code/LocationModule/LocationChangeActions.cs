using System.Collections.Generic;
using MADLEngine;
using Showcase.Code.PlayerModule;
using UnityEngine;

namespace Assets.Showcase.Code.LocationModule
{
    public class LocationChangeActions : IAction, IInitialisation, IFixedExecute
    {
        private LocationModule _locationModule;
        private List<GameObject> _locationsPrefabsList;
        private ProgressData _progressData;
        private PlayerDataContainer _playerData;
        private Transform _locationsRootTransform;
        private GameObject _currentLocationObject;
        private LocationLinks _currentLocationLinks;
        private int _spawnedLocationIndex;
        
        public LocationChangeActions(LocationModule locationModule, LocationsListConfiguration locationsList,
            ProgressData progressData, PlayerDataContainer playerDataContainer)
        {
            _locationModule = locationModule;
            _locationsPrefabsList = locationsList.LocationsPrefabsList;
            _progressData = progressData;
            _playerData = playerDataContainer;
        }
        
        public void Initialisation()
        {
            LocationsLinks links = (LocationsLinks) _locationModule.Links;
            _locationsRootTransform = links.GetLocationRootTransform();
            SpawnLocation(_progressData.CurrentLocationIndex);
        }
    
        public void FixedExecute(float fixedDeltaTime)
        {
            if (_spawnedLocationIndex != _progressData.CurrentLocationIndex)
            {
                DestroyCurrentLocation();
                SpawnLocation(_progressData.CurrentLocationIndex);
                ChangePlayerDataOnLocationSpawned();
            }
        }

        private void SpawnLocation(int index)
        {
            _currentLocationObject = GameObject.Instantiate(_locationsPrefabsList[index], _locationsRootTransform);
            _currentLocationLinks = _currentLocationObject.GetComponent<LocationLinks>();
            _locationModule.ChangeLocationLinks(_currentLocationLinks);
            _spawnedLocationIndex = index;
        }

        private void ChangePlayerDataOnLocationSpawned()
        {
            Transform playerStartPositionTransform = _currentLocationLinks.GetPlayerStartPositionTransform();
            _playerData.StartPosition = playerStartPositionTransform.position;
            _playerData.IsLocationChanged = true;
        }

        private void DestroyCurrentLocation()
        {
            GameObject.Destroy(_currentLocationObject);
        }


    }
}