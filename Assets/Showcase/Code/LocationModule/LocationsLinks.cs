using MADLEngine;
using UnityEngine;

namespace Assets.Showcase.Code.LocationModule
{
    public class LocationsLinks : BasicLinks
    {
        public Transform GetLocationRootTransform()
        {
            return SceneObjects[0].transform;
        }
    }
}