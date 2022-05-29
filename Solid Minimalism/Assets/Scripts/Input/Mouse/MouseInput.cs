using UnityEngine;

namespace Input.Mouse
{
    public class MouseInput : InputReceiver.InputReceiver, IMouseInput
    {
        protected override Vector2 GetCurrentInput()
        {
            var mousePosition = UnityEngine.Input.mousePosition;
            return new Vector2(mousePosition.x, mousePosition.y);
        }
    }
}