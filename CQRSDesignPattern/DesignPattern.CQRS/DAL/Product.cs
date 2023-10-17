namespace DesignPattern.CQRS.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public bool ProductStatus { get; set; }
    }
}
