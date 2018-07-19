namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        private const decimal GOLDEN_PRICE = 1.3M;

        public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
        {

        }

        public override decimal Price
        {
            get { return base.Price; }
            protected set
            {
                base.Price = value * GOLDEN_PRICE;
            }
        }
    }
}
