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
            UnitPrice = Math.Ceiling(UnitPrice * (1 + Tax) * 100) / 100;
            FinalPrice = Math.Ceiling(Cost * (1 + IncomePercent) * 100) / 100;
        }

        
    }
}
