using Assets.Showcase.Code.ShootingModule;
using MADLEngine;

namespace Assets.Showcase.Code.LocationModule
{
    public class LocationModule : BasicModule
    {
        private LocationLinks _locationLinks;

        public LocationLinks LocationLinks => _locationLinks;
    
        public override void Initialise()
        {
            _actions = new Actions();
            _locationLinks = new LocationLinks();
            Links.InitialiseLinks();
            InitialiseLocationChangeAction();
            InitialiseLocationModifyAction();
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
                Data.GetDataObjectOfType<LocationsListConfiguration>(), Data.GetDataObjectOfType<ProgressData>());
            _actions.Add(locationChangeAction);
        }
    
        private void InitialiseLocationModifyAction()
        {
            LocationModifyActions locationModifyActions =
                new LocationModifyActions(this,
                    Data.GetDataObjectOfType<LocationTilesList>(), Data.GetDataObjectOfType<BulletsImpactData>());
            _actions.Add(locationModifyActions);
        }

    }
}