using RuleSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet.Rules
{
    public class CheckPackUppRule : Rule, IRule
    {
        public CheckPackUppRule()
        {
            NextRule = null;
        }
        public bool Run(OrderModel orderModel)
        {
            if (orderModel.CargoCompanyId == 30)
            {
                Console.WriteLine("PackUpp kargo bildirimi.");

                return true;
            }

            return false;
        }

    }
}
