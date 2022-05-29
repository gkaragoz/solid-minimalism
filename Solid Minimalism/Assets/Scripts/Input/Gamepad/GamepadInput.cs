using UnityEngine;

namespace Input.Gamepad
{
    public class GamepadInput : InputReceiver.InputReceiver
    {
        protected override Vector2 GetCurrentInput()
        {
            return new Vector2(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical"));
        }
    }
}