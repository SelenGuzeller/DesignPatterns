using DessignPattern.ChainOfResponsibility.DAL;
using DessignPattern.ChainOfResponsibility.Models;

namespace DessignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi";
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Direktörü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme tutarı bölge direktörünün günlük ödeyebileceği limiti aştığı için işlem gerçekleştirilemedi, müşterinin günlük maksimum çekebileceği tutar 400.000₺ olup daha fazlası için birden fazla gün şubeye gelmesi gerekli..."; ;
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
             //   NextApprover.ProcessRequest(req); //bir sonraki kişi bulunmadığı için bu işlem kullanılamıyor.
            }
        }
    }
}
