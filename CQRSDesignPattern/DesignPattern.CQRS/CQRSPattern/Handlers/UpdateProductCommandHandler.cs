using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.ProductName = command.ProductName;
            values.ProductDescription = command.ProductDescription; 
            values.ProductPrice = command.ProductPrice;
            values.ProductStock = command.ProductStock;
            values.ProductStatus = true;

            _context.SaveChanges();
        }
    }
}
