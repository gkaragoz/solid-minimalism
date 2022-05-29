using UnityEngine;

namespace Tank
{
    public interface ITank
    {
        float MovementSpeed { get; }
        void MoveTo(Vector2 input);
        void RotateTo(Vector2 input, Camera camera);
    }
}