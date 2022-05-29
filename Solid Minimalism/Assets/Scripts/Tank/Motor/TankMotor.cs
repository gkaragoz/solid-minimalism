﻿using UnityEngine;

namespace Tank.Motor
{
    public class TankMotor : MonoBehaviour, ITankMotor
    {
        [SerializeField]
        private float _movementSpeed = 5f;

        public float MovementSpeed => _movementSpeed;
        
        [SerializeField] private Rigidbody2D _rigidbody;

        private Vector2 _desiredDirection;
        private Quaternion _desiredRotation;

        private void FixedUpdate()
        {
            _rigidbody.velocity = _desiredDirection * _movementSpeed;
            _rigidbody.SetRotation(_desiredRotation);
        }

        public void MoveTo(Vector2 direction)
        {
            _desiredDirection = direction;
        }

        public void StopMovement()
        {
            _desiredDirection = Vector2.zero;
        }

        public void RotateTo(Vector2 input, Camera camera)
        {
            var direction = new Vector3(input.x, input.y, 0f) - camera.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            
            var desiredRotation = Quaternion.AngleAxis(angle, Vector3.forward);
            
            _desiredRotation = desiredRotation;
        }
    }
}