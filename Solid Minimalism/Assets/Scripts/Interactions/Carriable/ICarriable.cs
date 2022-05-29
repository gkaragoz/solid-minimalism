using Interactions.Carrier;

namespace Interactions.Carriable
{
    public interface ICarriable
    {
        void OnTake(ICarrier carrierObject);
        void OnRelease();
    }
}