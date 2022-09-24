using RuleSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet.Rules
{
   public class CheckCargoYurticiRule:Rule,IRule
    {
        public CheckCargoYurticiRule()
        {
            NextRule = new CheckKargomSendeRule();
        }

        public bool Run(OrderModel orderModel)
        {
            if(orderModel.CargoCompanyId==12)
            {
                Console.WriteLine("Yurtici kargo bildirimi.");

                return true;
            }

            return false;
        }
    }
}
