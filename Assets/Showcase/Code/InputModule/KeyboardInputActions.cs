using CADLEngine;
using UnityEngine;

namespace Showcase.Code.InputModule
{
    public class KeyboardInputActions : IAction, IExecute, ICleanUp
    {
        private InputContainer _inputContainer;
        private InputSettings _inputSettings;
    
        public KeyboardInputActions(InputContainer inputContainer, InputSettings inputSettings)
        {
            _inputContainer = inputContainer;
            _inputSettings = inputSettings;
        }
    
        public void Execute(float deltaTime)
        {
            _inputContainer.horizontalAxis = Input.GetAxis("Horizontal");
            _inputContainer.verticalAxis = Input.GetAxis("Vertical");
        }

        public void Cleanup()
        {
            _inputContainer.Clear();
        }

        private void InputDebug()
        {
            Debug.Log($"H : {_inputContainer.horizontalAxis}, V : {_inputContainer.verticalAxis}" );
        }
    }
}

