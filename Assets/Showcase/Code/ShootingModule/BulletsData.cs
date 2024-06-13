using System;
using System.Collections.Generic;
using MADLEngine;
using MADLEngine.Extention;

namespace Assets.Showcase.Code.ShootingModule
{
    public class BulletsData
    {
        public Action<Scene2DActor> OnBulletAdded;
        public Action<Scene2DActor> OnBulletRemoved;

        private SerializableDictionary<Scene2DActor, BulletData> _bulletsList;

        public SerializableDictionary<Scene2DActor, BulletData> BulletsList
        {
            get => _bulletsList;
        }

        public BulletsData()
        {
            _bulletsList = new SerializableDictionary<Scene2DActor, BulletData>();
            _bulletsList.Dictionary = new List<DictionaryElement<Scene2DActor, BulletData>>();
        }

        public void AddBullet(Scene2DActor bulletActor, BulletData bulletData)
        {
            _bulletsList.Add(bulletActor, bulletData);
            OnBulletAdded?.Invoke(bulletActor);
        }

        public void RemoveBullet(Scene2DActor bulletActor)
        {
            if (_bulletsList.IsContainsKey(bulletActor))
            {
                _bulletsList.Remove(bulletActor);
            }
            OnBulletRemoved?.Invoke(bulletActor);
        }
    }
}