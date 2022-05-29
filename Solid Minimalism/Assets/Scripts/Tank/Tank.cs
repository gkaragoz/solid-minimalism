using Tank.Motor;
using UnityEngine;

namespace Tank
{
    [RequireComponent(typeof(ITankMotor))]
    public class Tank : MonoBehaviour, ITank
    {
        private ITankMotor _tankMotor;
        
        private void Awake()
        {
            _tankMotor = GetComponent<ITankMotor>();
        }

        public void MoveTo(Vector2 input)
        {
            _tankMotor.MoveTo(input);
        }

        public void StopMovement()
        {
            _tankMotor.StopMovement();
        }

        public void RotateTo(Vector2 input, Camera camera)
        {
            _tankMotor.RotateTo(input, camera);
        }
    }
}