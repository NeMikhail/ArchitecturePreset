using CADLEngine;
using UnityEngine;

namespace Showcase.Code.InputModule
{
    public class InputModule : BasicModule
    {
        public bool IsKeyboardInput;

        public override void Initialise()
        {
            _actions = new Actions();
            InitialiseInput();
        }
    
        private void InitialiseInput()
        {
            KeyboardInputActions keyboardInput = new KeyboardInputActions(
                Data.GetDataObjectOfType<InputContainer>(), Data.GetDataObjectOfType<InputSettings>());
            if (IsKeyboardInput)
            {
                _actions.Add(keyboardInput);
            }
        
        }
    }
}

