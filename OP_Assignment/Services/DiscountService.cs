namespace OP_Assignment.Services
{
    public class DiscountService
    {
        public decimal CalculateDiscount(decimal amount, string customerType)
        {
            return (customerType == "Loyal" && amount >= 100) ? amount * 0.1m : 0;
        }
    }
}