using UnityEngine;

namespace Tank
{
    public interface ITank
    {
        void MoveTo(Vector2 input);
        void StopMovement();
        void RotateTo(Vector2 input, Camera camera);
    }
}