using System.Collections.Generic;
using MADLEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    public class ShootingModule : BasicModule
    {
        private ShootingData _shootingData;
        private BulletsData _bulletsData;
        private BulletsImpactData _bulletsImpactData;
        
        
        public override void Initialise()
        {
            InitializeFields();
            InitialiseShootingAction();
            InitialiseBulletsAction();
        }

        private void InitializeFields()
        {
            _actions = new Actions();
            Links.InitialiseLinks();
            _shootingData = (ShootingData)Data;
            _bulletsData = new BulletsData();
            _bulletsImpactData = Data.GetDataObjectOfType<BulletsImpactData>();
        }
        
        private void InitialiseShootingAction()
        {
            ShootingAction shootingAction = new ShootingAction(_shootingData, Links, _bulletsData);
            _actions.Add(shootingAction);
        }

        private void InitialiseBulletsAction()
        {
            BulletsAction bulletsAction = new BulletsAction(_bulletsData, _bulletsImpactData);
            _actions.Add(bulletsAction);
        }
        
        
    }
}