using CADLEngine;
using Showcase.Code.InputModule;

namespace Showcase.Code.PlayerModule
{
    public class PlayerModule : BasicModule
    {
        public override void Initialise()
        {
            _actions = new Actions();
            InitialisePlayerMovement();
        }

        private void InitialisePlayerMovement()
        {
            PlayerMovementAction playerMovementAction = new PlayerMovementAction(
                Data.GetDataObjectOfType<InputContainer>(), Data.GetDataObjectOfType<PlayerSettings>(),
                Links);
            _actions.Add(playerMovementAction);
        
        }
    }
}
