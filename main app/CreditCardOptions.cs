using Stripe;

namespace NEA___D1
{
    internal class CreditCardOptions : AnyOf<string, TokenCardOptions>
    {
        public string Number { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Cvc { get; set; }
    }
}