using RuleSet.Models;
using RuleSet.Rules;
using System;

namespace RuleSet
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderModel orderModel = new OrderModel()
            {
                Id = 1,
                CargoCompanyId = 30
            };

            IRule firstRule = new CheckCargoYurticiRule();

            while (firstRule.NextRule!=null)
            {
                if (!firstRule.Run(orderModel))
                {
                    firstRule = firstRule.NextRule;
                }
                else
                {
                    Console.WriteLine("Bildirim tamamlandı.");
                }
            }

            if (firstRule.NextRule==null)
            {
                if (!firstRule.Run(orderModel))
                {
                    Console.WriteLine("Bildirim yapılmadı.");
                }
                else
                {
                    Console.WriteLine("Bildirim yapıldı.");

                }
            }
            
        }
    }
}
