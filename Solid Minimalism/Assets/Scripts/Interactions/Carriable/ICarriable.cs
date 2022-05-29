using Interactions.Carrier;

namespace Interactions.Carriable
{
    public interface ICarriable
    {
        void OnCarried(ICarrier carrierObject);
    }
}