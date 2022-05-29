﻿using UnityEngine;

namespace Tank.Motor
{
    public interface ITankMotor
    {
        float MovementSpeed { get; }
        void MoveTo(Vector2 input);
        void StopMovement();
        void RotateTo(Vector2 input, Camera camera);
    }
}