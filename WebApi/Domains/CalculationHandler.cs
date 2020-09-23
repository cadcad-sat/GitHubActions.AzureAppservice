using WebApi.Domains.Interfaces;

namespace WebApi.Domains
{
    public class CalculationHandler : ICalculationHandler
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
