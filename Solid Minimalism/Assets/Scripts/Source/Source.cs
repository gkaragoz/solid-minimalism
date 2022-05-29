using UnityEngine;

namespace Source
{
    public abstract class Source : MonoBehaviour, ISource
    {
        [SerializeField]
        protected SourceType _sourceType;
        public SourceType Type => _sourceType;

        [SerializeField] private Collider2D _triggerArea;

        protected void EnableTriggerArea()
        {
            _triggerArea.enabled = true;
        }
        
        protected void DisableTriggerArea()
        {
            _triggerArea.enabled = false;
        }
        
        protected virtual void MoveTo(Transform parentTransform)
        {
            transform.SetParent(parentTransform);
            transform.localPosition = Vector3.zero;
        }
    }
}