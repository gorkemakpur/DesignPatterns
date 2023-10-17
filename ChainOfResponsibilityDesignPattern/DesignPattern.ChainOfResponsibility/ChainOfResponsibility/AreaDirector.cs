using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        Context context = new Context();
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;

                customerProcess.EmployeeName = "Bölge Direktörü - Akpur Görkem Aziz";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talep Ettiği Tutar Ödendi";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();

            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;

                customerProcess.EmployeeName = "Bölge Direktörü - Akpur Görkem Aziz";
                customerProcess.Description = "Para Çekme Tutarı Bölge Direktörünün Günlük Ödeyebileceği Limiti Aştığı İçin İşlem Gerçekleştirilemedi Müşterinin " +
                    "Günlük Maksimum Çekebileceği Tutar 400.000 TL olup daha fazlası için birden fazla gün şubeye gelmesi gerekmektedir.";

                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
