using Tank.Motor;
using UnityEngine;

namespace Tank
{
    [RequireComponent(typeof(ITankMotor))]
    public class Tank : MonoBehaviour, ITank
    {
        [SerializeField] private float _movementSpeed = 1f;
        
        public float MovementSpeed => _movementSpeed;
        private ITankMotor _tankMotor;

        private void Awake()
        {
            _tankMotor = GetComponent<ITankMotor>();
        }

        public void MoveTo(Vector2 input)
        {
            _tankMotor.MoveTo(input * MovementSpeed * Time.deltaTime);
        }

        public void RotateTo(Vector2 input, Camera camera)
        {
            var direction = new Vector3(input.x, input.y, 0f) - camera.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            
            var desiredRotation = Quaternion.AngleAxis(angle, Vector3.forward);
            _tankMotor.RotateTo(desiredRotation);
        }
    }
}