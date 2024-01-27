namespace FactoryDependencyInjection.Data.Interfaces
{
    public interface IFactory
    {
        public IPaymentMethod Create(string method);
    }
}
