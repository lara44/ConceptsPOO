using FactoryDependencyInjection.Data.Concrets;
using FactoryDependencyInjection.Data.Interfaces;

namespace FactoryDependencyInjection.Data.Factory
{
    public class PaymentFactory : IFactory
    {
        private readonly DaviplataMethod _daviplataMethod;
        private readonly NequiMethod _nequiMethod;

        public PaymentFactory(DaviplataMethod daviplataMethod, NequiMethod nequiPayment)
        {
            this._daviplataMethod = daviplataMethod;
            this._nequiMethod = nequiPayment;
        }

        public IPaymentMethod Create(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "Nequi":
                    return _nequiMethod;
                case "Daviplata":
                    return _daviplataMethod;
                default:
                    //return "Payment Method: is not supported.";
                    throw new ArgumentException($"Payment Method: {paymentMethod} is not supported.");
            }
        }
    }
}
