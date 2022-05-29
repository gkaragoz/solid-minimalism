using System.Collections.Generic;
using Interactions.Carriable;
using UnityEngine;

namespace Interactions.Carrier
{
    public interface ICarrier
    {
        Transform CarrySlotTransform { get; }
        List<ICarriable> CarriedObjects { get; }

        void CarryIt(ICarriable carriedObject);
        void DropIt();
    }
}