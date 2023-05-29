
namespace Interface.Services
{
    class BrazilTaxService : ITaxService // BrazilTaxService implements ITaxService interface
    {
        public double tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
