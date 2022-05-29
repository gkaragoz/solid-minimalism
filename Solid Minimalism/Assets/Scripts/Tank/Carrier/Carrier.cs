using System.Collections.Generic;
using Interactions.Carriable;
using Interactions.Carrier;
using UnityEngine;

namespace Tank.Carrier
{
    public class Carrier : MonoBehaviour, ICarrier
    {
        public Transform CarrySlotTransform => _carrySlotTransform;
        public List<ICarriable> CarriedObjects { get; } = new();

        [SerializeField] private Transform _carrySlotTransform;
        
        public void CarryIt(ICarriable carriedObject)
        {
            CarriedObjects.Add(carriedObject);
            
            carriedObject.OnTake(this);
        }

        public void DropIt()
        {
            if (CarriedObjects.Count == 0)
                return;

            var droppedObject = CarriedObjects[^1];
            droppedObject.OnRelease();

            CarriedObjects.Remove(droppedObject);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out ICarriable carriedObject))
                CarryIt(carriedObject);
        }
    }
}