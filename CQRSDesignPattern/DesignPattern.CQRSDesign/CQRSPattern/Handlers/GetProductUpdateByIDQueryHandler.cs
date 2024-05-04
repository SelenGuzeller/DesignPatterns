using DesignPattern.CQRSDesign.CQRSPattern.Queries;
using DesignPattern.CQRSDesign.CQRSPattern.Results;
using DesignPattern.CQRSDesign.DAL;

namespace DesignPattern.CQRSDesign.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var values = _context.Products.Find(query.ID);
            return new GetProductUpdateQueryResult
            {
                Name = values.Name,
                ProductID = values.ProductID,
                Price = values.Price,
                Stock = values.Stock,
                Description = values.Description,


            };
        }
    }
}
