using System.Collections.Generic;
using UnityEngine;

namespace Assets.Showcase.Code.LocationModule
{
    [CreateAssetMenu(fileName = "LocationsList" , menuName = "Showcase/LocationModule/LocationsList", order = 0)]
    public class LocationsListConfiguration : ScriptableObject
    {
        public List<GameObject> LocationsPrefabsList;
    }
}
