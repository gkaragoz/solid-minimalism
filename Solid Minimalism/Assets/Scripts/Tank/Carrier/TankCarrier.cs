using Interactions.Carriable;
using UnityEngine;

namespace Tank.Carrier
{
    public class TankCarrier : MonoBehaviour, ITankCarrier
    {
        public Transform CarrySlotTransform => _carrySlotTransform;

        [SerializeField] private Transform _carrySlotTransform;
        
        private Source.Source _carriedSource;

        public void CarryIt(ICarriable carriedObject)
        {
            _carriedSource = carriedObject as Source.Source;
            _carriedSource.OnCarried(this);
        }

        public void DropIt()
        {
            if (_carriedSource == null)
                return;
            
            _carriedSource.OnDropped();
            _carriedSource = null;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out ICarriable carriedObject))
                CarryIt(carriedObject);   
        }
    }
}