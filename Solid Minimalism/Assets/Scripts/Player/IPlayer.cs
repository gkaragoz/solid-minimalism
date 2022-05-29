using Input;
using Input.Controller;
using Tank;
using UnityEngine;

namespace Player
{
    public interface IPlayer
    {
         InputControllerType InputControllerType { get; }
         InputController InputController { get; }
         Camera Camera { get; }
         ITank Tank { get; }
    }
}