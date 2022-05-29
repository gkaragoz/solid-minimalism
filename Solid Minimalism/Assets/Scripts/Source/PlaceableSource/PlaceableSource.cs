using Interactions.Carrier;
using Interactions.Placeable;
using UnityEngine;

namespace Source.PlaceableSource
{
    public class PlaceableSource : Source, IPlacable
    {
        public void OnTake(ICarrier carrierObject)
        {
            DisableTriggerArea();
            
            MoveTo(carrierObject.CarrySlotTransform);
        }

        public void OnRelease()
        {
            Debug.Log($"Object {gameObject.name} placed.");
        }
    }
}