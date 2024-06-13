using Assets.Showcase.Code.ShootingModule;
using MADLEngine;
using MADLEngine.Extention;
using UnityEngine;

namespace Showcase.Code.PlayerModule
{
    public class PlayerLinks : BasicLinks
    {
        public Vector2 GetCurrentBulletSpawnPosition()
        {
            return GetObjectInChildsByTag(ShootingConstants.BULLET_START_TAG).transform.position;
        }

    }
}


