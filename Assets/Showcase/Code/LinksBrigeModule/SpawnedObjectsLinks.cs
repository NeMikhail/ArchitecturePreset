using MADLEngine;
using MADLEngine.Extention;
using UnityEngine;

public class SpawnedObjectsLinks : BasicLinks
{
    public GameObject GetPlayerObject()
    {
        GameObject playerObject = SceneObjects.GetObjectByTag(LinksBrigeConstants.PLAYER_TAG);
        if (playerObject == null)
        {
            Debug.Log("Player object not found");
        }
        return playerObject;
    }
}
