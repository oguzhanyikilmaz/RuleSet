using RuleSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet
{
   public interface IRule
    {
        public bool Run(OrderModel orderModel);
        public IRule NextRule { get; set; }
    }
}
