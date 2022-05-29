using Input.InputReceiver;
using Tank;
using UnityEngine;

namespace Player
{
    public interface IPlayer
    {
        Camera Camera { get; }
        ITank Tank { get; }
        IInputReceiver MovementInput { get; }
        IInputReceiver RotationInput { get; }
    }
}