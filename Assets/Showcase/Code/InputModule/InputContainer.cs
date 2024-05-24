using UnityEngine;

namespace Showcase.Code.InputModule
{
    [CreateAssetMenu(fileName = "InputContainer" , menuName = "Showcase/InputModule/InputContainer", order = 0)]
    public class InputContainer : ScriptableObject
    {
        public float horizontalAxis;
        public float verticalAxis;

        public void Clear()
        {
            horizontalAxis = 0;
            verticalAxis = 0;
        }
    }
}


