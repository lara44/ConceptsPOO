using FactoryDependencyInjection.Data.Interfaces;

namespace FactoryDependencyInjection.Data.Concrets
{
    public class DaviplataMethod : IPaymentMethod
    {
        public string ApplyPay()
        {
            return "Daviplata procesó el pago correctamente!";
        }
    }
}
