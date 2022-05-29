using Input.InputReceiver;
using Input.Keyboard;
using Input.Mouse;
using Tank;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour, IPlayer
    {
        public Camera Camera { get; private set; }
        public ITank Tank { get; private set; }
        public IInputReceiver MovementInput { get; private set; }
        public IInputReceiver RotationInput { get; private set; }

        private void Awake()
        {
            Camera = Camera.main;
            Tank = GetComponentInChildren<ITank>();
            MovementInput = GetComponent<IKeyboardInput>();
            RotationInput = GetComponent<IMouseInput>();
        }

        private void Update()
        {
            if (MovementInput.HasInput())
                Tank.MoveTo(MovementInput.CurrentInput);

            if (RotationInput.HasInput())
                Tank.RotateTo(RotationInput.CurrentInput, Camera);
        }
    }
}
