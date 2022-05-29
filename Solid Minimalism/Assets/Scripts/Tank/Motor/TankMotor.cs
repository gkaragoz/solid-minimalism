using UnityEngine;

namespace Tank.Motor
{
    public class TankMotor : MonoBehaviour, ITankMotor
    {
        public Transform TankTransform => transform;

        public void MoveTo(Vector2 direction)
        {
            TankTransform.localPosition += new Vector3(direction.x, direction.y, 0f);
        }

        public void RotateTo(Quaternion rotation)
        {
            TankTransform.localRotation = rotation;
        }
    }
}