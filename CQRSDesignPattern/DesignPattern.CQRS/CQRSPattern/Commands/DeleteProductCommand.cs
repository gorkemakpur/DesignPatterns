namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class DeleteProductCommand
    {
        public DeleteProductCommand(int productID)
        {
            ProductID = productID;
        }

        public int ProductID { get; set; }
    }
}
