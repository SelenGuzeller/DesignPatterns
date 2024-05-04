namespace DesignPattern.CQRSDesign.CQRSPattern.Queries
{
    public class GetProductUpdateByIDQuery
    {
        public GetProductUpdateByIDQuery(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
