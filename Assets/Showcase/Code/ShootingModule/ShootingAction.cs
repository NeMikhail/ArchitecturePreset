using System.Collections.Generic;
using Assets.Showcase.Code.ShootingModule;
using MADLEngine;
using MADLEngine.Extention;
using Showcase.Code.Enum;
using UnityEngine;

public class ShootingAction : IAction, IInitialisation, IFixedExecute
{
    private ShootingData _shootingData;
    private Transform _bulletsRootTransform;

    public ShootingAction(ShootingData shootingData, ILinks links)
    {
        _shootingData = shootingData;
        _bulletsRootTransform = links.SceneObjects.GetObjectByTag(ShootingConstants.BULLETS_ROOT_TAG).transform;
    }
    public void Initialisation()
    {
        
    }

    public void FixedExecute(float fixedDeltaTime)
    {
        List<IShootingDataContainer> shootingDataContainers = _shootingData.GetShootingDataContainers();
        Debug.Log(shootingDataContainers.Count);
        if (shootingDataContainers.Count != 0)
        {
            TryShootAllShooters(shootingDataContainers);
        }
        
    }

    private void TryShootAllShooters(List<IShootingDataContainer> shootingDataContainers)
    {
        foreach (IShootingDataContainer shootingDataContainer in shootingDataContainers)
        {
            if (shootingDataContainer.IsShooting)
            {
                Shoot(shootingDataContainer);
                shootingDataContainer.IsShooting = false;
            }
        }
    }

    private void Shoot(IShootingDataContainer shootingDataContainer)
    {
        Vector3 rotationEuler = GetBulletRotation(shootingDataContainer.BulletDirection);
        Quaternion rotation = Quaternion.Euler(rotationEuler);
        Vector3 position = shootingDataContainer.BulletSpawnPosition;
        GameObject bulletObject = GameObject.Instantiate(
            shootingDataContainer.BulletConfiguration.BulletPrefab, position, rotation, _bulletsRootTransform);
    }

    private Vector3 GetBulletRotation(Direction direction)
    {
        Vector3 rotation = Vector3.zero;
        switch (direction)
        {
            case Direction.Left :
                rotation = new Vector3(0, 0, 90);
                break;
            case Direction.Right :
                rotation =new Vector3(0, 0, -90);
                break;
            case Direction.Up :
                rotation = new Vector3(0, 0, 0);
                break;
            case Direction.Down :
                rotation = new Vector3(0, 0, 180);
                break;
            default:
                break;
        }
        return rotation;
    }
}
