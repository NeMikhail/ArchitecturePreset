using UnityEngine;

namespace Showcase.Code.InputModule
{
    [CreateAssetMenu(fileName = "InputContainer" , menuName = "Showcase/InputModule/InputContainer", order = 0)]
    public class InputContainer : ScriptableObject
    {
        public float HorizontalAxis;
        public float VerticalAxis;
        public bool WasRightMouseButtonDown;
        public bool WasLeftMouseButtonDown;

        public void Clear()
        {
            HorizontalAxis = 0;
            VerticalAxis = 0;
        }
    }
}


