using System.Collections.Generic;
using MADLEngine;
using UnityEngine;

namespace Assets.Showcase.Code.LocationModule
{
    public class LocationChangeActions : IAction, IInitialisation, IFixedExecute
    {
        private LocationModule _locationModule;
        private List<GameObject> _locationsPrefabsList;
        private ProgressData _progressData;
        private Transform _locationsRootTransform;
        private GameObject _currentLocationObject;
        private int _spawnedLocationIndex;
        
        public LocationChangeActions(LocationModule locationModule, LocationsListConfiguration locationsList,
            ProgressData progressData)
        {
            _locationModule = locationModule;
            _locationsPrefabsList = locationsList.LocationsPrefabsList;
            _progressData = progressData;
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
            }
        }

        private void SpawnLocation(int index)
        {
            _currentLocationObject = GameObject.Instantiate(_locationsPrefabsList[index], _locationsRootTransform);
            LocationLinks locationLinks = _currentLocationObject.GetComponent<LocationLinks>();
            _locationModule.ChangeLocationLinks(locationLinks);
            _spawnedLocationIndex = index;
        }

        private void DestroyCurrentLocation()
        {
            GameObject.Destroy(_currentLocationObject);
        }


    }
}