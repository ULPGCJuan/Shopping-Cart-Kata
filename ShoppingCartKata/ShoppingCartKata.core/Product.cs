namespace ShoppingCartKata.core
{
    public class Product
    {
        public string Name { get; }
        public double Cost { get; }
        public double IncomePercent { get; }
        public double Tax { get; }
        public double UnitPrice { get; }  
        public double FinalPrice { get; } 

        public Product(string name, double cost, double incomePercent, double tax)
        {
            Name = name;
            Cost = cost;
            IncomePercent = incomePercent;
            Tax = tax;
            UnitPrice = CalculateUnitPrice();
            FinalPrice = CalculateFinalPrice();
        }

        private double CalculateUnitPrice()
        {
            var unitPrice = Cost * (1 + IncomePercent);
            return Math.Ceiling(unitPrice * 100) / 100; 
        }

        private double CalculateFinalPrice()
        {
            var finalPrice = UnitPrice * (1 + Tax);
            return 
        }
    }
}
