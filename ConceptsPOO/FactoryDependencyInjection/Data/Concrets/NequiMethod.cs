using FactoryDependencyInjection.Data.Interfaces;

namespace FactoryDependencyInjection.Data.Concrets
{
    public class NequiMethod : IPaymentMethod
    {
        public string ApplyPay()
        {
            return "Nequi procesó el pago correctamente!";
        }
    }
}
