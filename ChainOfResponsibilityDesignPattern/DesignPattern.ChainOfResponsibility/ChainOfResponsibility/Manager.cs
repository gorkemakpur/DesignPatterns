using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        Context context = new Context();
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            if (req.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;

                customerProcess.EmployeeName = "Şube Müdürü - Aziz G. Akpur";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;

                customerProcess.EmployeeName = "Şube Müdürü - Aziz G. Akpur";
                customerProcess.Description = "Para Çekme Tutarı Şube Müdürünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Bölge Direktörüne Yönlendirildi";

                context.CustomerProcesses.Add(customerProcess); 
                context.SaveChanges();

                NextApprover.ProcessRequest(req);
            }
        }
    }
}
