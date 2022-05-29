using Interactions.Carriable;
using Interactions.Carrier;
using Interactions.Droppable;
using Interactions.Placable;
using UnityEngine;

namespace Source
{
    public class Source : MonoBehaviour, ISource, ICarriable, IPlacable, IDroppable
    {
        [SerializeField]
        protected SourceType _sourceType;
        public SourceType Type => _sourceType;

        [SerializeField] protected Collider2D _triggerArea;

        private void MoveTo(Transform parentTransform)
        {
            transform.SetParent(parentTransform);
            transform.localPosition = Vector3.zero;
        }

        public void OnCarried(ICarrier carrierObject)
        {
            _triggerArea.enabled = false;
            
            MoveTo(carrierObject.CarrySlotTransform);
        }

        public void OnPlaced()
        {
            _triggerArea.enabled = false;
        }

        public void OnDropped()
        {
            _triggerArea.enabled = true;
        }
    }
}