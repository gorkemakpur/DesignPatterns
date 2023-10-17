using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.EntityLayer.Concrete
{
    public class Process
    {
        public int ProcessID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public decimal Amount { get; set; }
    }
}
