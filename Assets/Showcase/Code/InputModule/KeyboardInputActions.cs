using MADLEngine;
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
            _inputContainer.HorizontalAxis = Input.GetAxis("Horizontal");
            _inputContainer.VerticalAxis = Input.GetAxis("Vertical");
            _inputContainer.WasLeftMouseButtonDown = Input.GetKey(KeyCode.Mouse0);
            _inputContainer.WasRightMouseButtonDown = Input.GetKey(KeyCode.Mouse1);
        }

        public void Cleanup()
        {
            _inputContainer.Clear();
        }

        private void InputDebug()
        {
            Debug.Log($"H : {_inputContainer.HorizontalAxis}, V : {_inputContainer.VerticalAxis}" );
        }
    }
}

