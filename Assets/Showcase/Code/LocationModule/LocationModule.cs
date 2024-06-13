using Assets.Showcase.Code.ShootingModule;
using MADLEngine;
using Showcase.Code.PlayerModule;

namespace Assets.Showcase.Code.LocationModule
{
    public class LocationModule : BasicModule
    {
        private LocationLinks _locationLinks;

        private LocationsListConfiguration _locationsListConfiguration;
        private LocationTilesList _locationTilesList;
        private ProgressData _progressData;
        private PlayerDataContainer _playerData;
        private BulletsImpactData _bulletsImpactData;
        

        public LocationLinks LocationLinks => _locationLinks;
    
        public override void Initialise()
        {
            _actions = new Actions();
            Links.InitialiseLinks();
            InitializeFields();
            InitialiseLocationChangeAction();
            InitialiseLocationModifyAction();
        }

        private void InitializeFields()
        {
            _locationsListConfiguration = Data.GetDataObjectOfType<LocationsListConfiguration>();
            _locationTilesList = Data.GetDataObjectOfType<LocationTilesList>();
            _progressData = Data.GetDataObjectOfType<ProgressData>();
            _playerData = Data.GetDataObjectOfType<PlayerDataContainer>();
            _bulletsImpactData = Data.GetDataObjectOfType<BulletsImpactData>();


        }
    
        public void ChangeLocationLinks(LocationLinks links)
        {
            _locationLinks = links;
            _locationLinks.InitialiseLinks();
            Links.SceneObjects.Remove(Links.GetObjectWithComponent<LocationLinks>());
            Links.SceneObjects.Add(_locationLinks.gameObject);
        }

        private void InitialiseLocationChangeAction()
        {
            LocationChangeActions locationChangeAction = new LocationChangeActions(this,
                _locationsListConfiguration, _progressData, _playerData);
            _actions.Add(locationChangeAction);
        }
    
        private void InitialiseLocationModifyAction()
        {
            LocationModifyActions locationModifyActions =
                new LocationModifyActions(this, _locationTilesList, _bulletsImpactData);
            _actions.Add(locationModifyActions);
        }

    }
}