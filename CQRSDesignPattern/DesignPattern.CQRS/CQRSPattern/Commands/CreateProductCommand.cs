namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDescription { get; set; }
    }
}
