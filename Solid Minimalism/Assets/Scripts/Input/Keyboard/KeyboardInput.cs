using UnityEngine;

namespace Input.Keyboard
{
    public class KeyboardInput : InputReceiver.InputReceiver, IKeyboardInput
    {
        protected override Vector2 GetCurrentInput()
        {
            return new Vector2(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical"));
        }
    }
}