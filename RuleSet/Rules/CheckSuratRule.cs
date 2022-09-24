using RuleSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet.Rules
{
    public class CheckSuratRule : Rule, IRule
    {
        public CheckSuratRule()
        {
            NextRule = new CheckPackUppRule();
        }
        public bool Run(OrderModel orderModel)
        {
            if (orderModel.CargoCompanyId == 31)
            {
                Console.WriteLine("Surat kargo bildirimi.");

                return true;
            }

            return false;
        }

    }
}
