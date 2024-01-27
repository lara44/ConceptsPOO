using FactoryDependencyInjection.Data.Interfaces;

namespace FactoryDependencyInjection.Data.Services
{
    public class PaymentService
    {
        private IPaymentMethod? _method;

        public void SetPaymentMethod(IPaymentMethod method)
        {
            this._method = method;
        }

        public string Proccess()
        {
            if (this._method == null)
            {
                throw new InvalidOperationException("Payment method has not been set.");
            }

            try
            {
                return this._method.ApplyPay();
            }
            catch (Exception ex)
            {
                // Manejar la excepción apropiadamente, por ejemplo, registrándola
                // y/o propagándola según sea necesario.
                throw new InvalidOperationException("Error processing payment.", ex);
            }
        }
    }
}
