using Input;
using Input.Controller;
using Tank;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour, IPlayer
    {
        [SerializeField] private InputControllerType _inputControllerType = InputControllerType.KeyboardMouse;

        public InputControllerType InputControllerType => _inputControllerType;
        public InputController InputController { get; private set; }
        public Camera Camera { get; private set; }
        public ITank Tank { get; private set; }

        private void Awake()
        {
            CreateInputController();
            
            Camera = Camera.main;
            Tank = GetComponentInChildren<ITank>();
        }

        private void CreateInputController()
        {
            switch (InputControllerType)
            {
                case InputControllerType.Gamepad:
                    InputController = gameObject.AddComponent<GamepadController>();
                    break;
                case InputControllerType.KeyboardMouse:
                    InputController = gameObject.AddComponent<KeyboardMouseController>();
                    break;
            }
        }

        private void Update()
        {
            if (InputController.HasMovementInput())
                Tank.MoveTo(InputController.GetMovementInput());
            else
                Tank.StopMovement();

            if (InputController.HasRotationInput())
                Tank.RotateTo(InputController.GetRotationInput(), Camera);
        }
    }
}
