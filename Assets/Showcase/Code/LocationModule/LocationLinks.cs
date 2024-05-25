using System.Collections.Generic;
using MADLEngine;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Showcase.Code.LocationModule
{
    public class LocationLinks : BasicLinks
    {
        private List<Tilemap> _tilemapsList;

        public override void InitialiseLinks()
        {
            _tilemapsList = GetComponentsFromObjectsList<Tilemap>();
        }
    
        private Tilemap GetTilemapByTag(string tag)
        {
            foreach (Tilemap tilemap in _tilemapsList)
            {
                if (tilemap.gameObject.tag == tag)
                {
                    return tilemap;
                }
            }
            Debug.Log($"No tilemap with tag {tag} found");
            return null;
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
    }
}
