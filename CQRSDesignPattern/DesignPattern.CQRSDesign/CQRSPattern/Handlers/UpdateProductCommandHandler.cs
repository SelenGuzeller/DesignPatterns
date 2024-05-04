using DesignPattern.CQRSDesign.CQRSPattern.Command;
using DesignPattern.CQRSDesign.DAL;

namespace DesignPattern.CQRSDesign.CQRSPattern.Handlers
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
            var values=_context.Products.Find(command.ProductID);
            values.Name= command.Name;
            values.Description= command.Description;
            values.ProductID= command.ProductID;
            values.Status = true;
            values.Stock= command.Stock;
            values.Price= command.Price;
            _context.SaveChanges();

        }
    }
}
