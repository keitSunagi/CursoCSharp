using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Entities;
using Interfaces.Entities.Interfaces;

namespace Interfaces.Services
{
     class PaymentService
    {
        public static double ProcessContract(Contract contract,int mounth)
        {
            double sum = contract.TotalValue  * mounth;
        }
        
    }
}
