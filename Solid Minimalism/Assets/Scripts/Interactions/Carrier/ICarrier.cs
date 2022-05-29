using Interactions.Carriable;
using UnityEngine;

namespace Interactions.Carrier
{
    public interface ICarrier
    {
        Transform CarrySlotTransform { get; }
        
        void CarryIt(ICarriable carriedObject);
        void DropIt();
    }
}