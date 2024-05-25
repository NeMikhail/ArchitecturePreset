using Assets.Showcase.Code.ShootingModule;
using MADLEngine;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Showcase.Code.LocationModule
{
    public class LocationModifyActions : IAction, IInitialisation, IFixedExecute
    {
        private LocationModule _locationModule;
        private LocationTilesList _tilesList;
        private BulletsImpactData _bulletsImpacts;

        private Tile _basicWallTile;
        private Tile _reinforcedWallTile;
        private Tile _unbreakableWallTile;

        public LocationModifyActions(LocationModule locationModule,
            LocationTilesList tilesList, BulletsImpactData bulletsImpactData)
        {
            _locationModule = locationModule;
            _tilesList = tilesList;
            _bulletsImpacts = bulletsImpactData;
        }
    
        public void Initialisation()
        {
            _basicWallTile = _tilesList.GetTileByName(LocationConstants.BASIC_WALL_NAME);
            _reinforcedWallTile = _tilesList.GetTileByName(LocationConstants.REINFORCED_WALL_NAME);
            _unbreakableWallTile = _tilesList.GetTileByName(LocationConstants.UNBREAKABLE_WALL_NAME);
        }

        public void FixedExecute(float fixedDeltaTime)
        {
            ImpactData impactData = _bulletsImpacts.GetAndRemoveWallImpactData();
            if (impactData != null)
            {
                TryDestroyWallOnPosition(impactData.GetRoundedPosition(), impactData.BulletConfiguration.Power);
            }

        }

        private void TryDestroyWallOnPosition(Vector2Int position, int power)
        {
            Tilemap wallsTilemap = _locationModule.LocationLinks.GetWallsTilemap();
            Tile wallTile = wallsTilemap.GetTile<Tile>((Vector3Int)position);
            if (wallTile == _basicWallTile && power > 0)
            {
                wallsTilemap.SetTile((Vector3Int)position, null);
            }
            else if (wallTile == _reinforcedWallTile && power > 1)
            {
                wallsTilemap.SetTile((Vector3Int)position, null);
            }
            else if (wallTile == _unbreakableWallTile)
            {
            
            }
        }
    }
}