using Interactions.Carrier;
using Interactions.Droppable;
using UnityEngine;

namespace Source.DroppableSource
{
    public class DroppableSource : Source, IDroppable
    {
        public void OnTake(ICarrier carrierObject)
        {
            DisableTriggerArea();
            
            MoveTo(carrierObject.CarrySlotTransform);
        }

        public void OnRelease()
        {
            EnableTriggerArea();
            
            Debug.Log($"Object {gameObject.name} released.");
        }
    }
}