using DessignPattern.ChainOfResponsibility.Models;

namespace DessignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover; //kendi ve miras aldığı sınıflardan erişebilmesi için

        public void SetNextApprover(Employee superVisor)
        {
            this.NextApprover = superVisor;
        }

        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
