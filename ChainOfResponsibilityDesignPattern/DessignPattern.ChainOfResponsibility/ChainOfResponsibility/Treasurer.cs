using DessignPattern.ChainOfResponsibility.DAL;
using DessignPattern.ChainOfResponsibility.Models;

namespace DessignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();   
                customerProcess.Amount=req.Amount.ToString();
                customerProcess.Name=req.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi";
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
            }
            else if(NextApprover !=null) 
            {
                CustomerProcess customerProcess= new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name=req.Name;
                customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
                customerProcess.Description = "Para çekme tutarı veznedarın günlük ödeyebileceği limiti aştığı için işlem şube müdür yardımcısına yönlendirildi"; ;
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req); //bir üst kişiye yönlendirme işlemini yapıyorum
            }
        }
    }
}
