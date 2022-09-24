using RuleSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet.Rules
{
    public class CheckKargomSendeRule : Rule, IRule
    {
        public CheckKargomSendeRule()
        {
            NextRule = new CheckPackUppRule();
        }
        public bool Run(OrderModel orderModel)
        {
            if (orderModel.CargoCompanyId == 29)
            {
                Console.WriteLine("KargomSende kargo bildirimi.");

                return true;
            }

            return false;
        }
    }
}
