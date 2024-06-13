using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Showcase.Code.LocationModule
{
    [CreateAssetMenu(fileName = "LocationTilesList" , menuName = "Showcase/LocationModule/LocationTilesList", order = 0)]
    public class LocationTilesList : ScriptableObject
    {
        public List<Tile> TileList;

        public Tile GetTileByName(string name)
        {
            foreach (Tile tile in TileList)
            {
                if (tile.name == name)
                {
                    return tile;
                }
            }
            Debug.Log($"Tile with name {name} not found");
            return null;
        }
    }
}
