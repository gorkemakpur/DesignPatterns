namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int ID)
        {
            Id = ID;
        }

        public int Id { get; set; }
    }
}
