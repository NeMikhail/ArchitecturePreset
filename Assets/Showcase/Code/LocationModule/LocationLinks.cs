using System.Collections.Generic;
using MADLEngine;
using MADLEngine.Extention;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Showcase.Code.LocationModule
{
    public class LocationLinks : BasicLinks
    {
        private List<Tilemap> _tilemapsList;
        private List<Transform> _transformsList;

        public override void InitialiseLinks()
        {
            _tilemapsList = GetComponentsFromObjectsList<Tilemap>();
            _transformsList = GetComponentsFromObjectsList<Transform>();
        }

        private Tilemap GetTilemapByTag(string tag)
        {
            Tilemap tilemap = _tilemapsList.GetComponentByObjectTag<Tilemap>(tag);
            if (tilemap == null)
            {
                Debug.Log($"No tilemap with tag {tag} found");
            }
            return tilemap;
        }
    
        public Tilemap GetWallsTilemap()
        {
            return GetTilemapByTag(LocationConstants.WALLS_TAG);
        }
    
        public Tilemap GetGroundTilemap()
        {
            return GetTilemapByTag(LocationConstants.GROUND_TAG);
        }
    
        public Tilemap GetWaterTilemap()
        {
            return GetTilemapByTag(LocationConstants.WATER_TAG);
        }
    
        public Tilemap GetBushesTilemap()
        {
            return GetTilemapByTag(LocationConstants.BUSHES_TAG);
        }

        public Grid GetGrid()
        {
            return GetComponentFromObjectsList<Grid>();
        }

        public Transform GetPlayerStartPositionTransform()
        {
            Transform playerStartPositionTransform =
                _transformsList.GetComponentByObjectTag(LocationConstants.PLAYER_POSITION_TAG);
            if (playerStartPositionTransform == null)
            {
                Debug.Log($"No PlayerStartPositionTransform found");
            }
            return playerStartPositionTransform;
        }
    }
}
