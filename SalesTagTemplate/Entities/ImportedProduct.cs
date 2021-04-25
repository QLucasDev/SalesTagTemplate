
namespace SalesTagTemplate.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }
         
        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.customsFee = customsFee;
        }
        public double totalPrice()
        {
            return Price + customsFee;
        }
        public override string PriceTag()
        {
            return Name
                + " $ "
                + totalPrice()
                + "(Customs fee: $ " + customsFee + ")";
        }
    }
}
