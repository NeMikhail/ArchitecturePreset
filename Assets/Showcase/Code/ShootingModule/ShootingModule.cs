using System.Collections.Generic;
using MADLEngine;

namespace Assets.Showcase.Code.ShootingModule
{
    public class ShootingModule : BasicModule
    {
        private ShootingData _shootingData;
        
        
        public override void Initialise()
        {
            InitializeFields();
            InitialiseShootingAction();
        }

        private void InitializeFields()
        {
            _actions = new Actions();
            Links.InitialiseLinks();
            _shootingData = (ShootingData)Data;
        }
        
        private void InitialiseShootingAction()
        {
            ShootingAction shootingAction = new ShootingAction(_shootingData, Links);
            _actions.Add(shootingAction);
        }
        
        
    }
}