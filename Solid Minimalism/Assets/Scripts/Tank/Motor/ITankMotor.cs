using UnityEngine;

namespace Tank.Motor
{
    public interface ITankMotor
    {
        Transform TankTransform { get; }
        void MoveTo(Vector2 direction);
        void RotateTo(Quaternion rotation);
    }
}