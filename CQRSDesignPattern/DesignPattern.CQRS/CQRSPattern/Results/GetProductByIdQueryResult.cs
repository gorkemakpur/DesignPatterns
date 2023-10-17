namespace DesignPattern.CQRS.CQRSPattern.Results
{
    public class GetProductByIdQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
    }
}
