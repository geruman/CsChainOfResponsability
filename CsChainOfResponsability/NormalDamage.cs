using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsChainOfResponsability
{
    public class NormalDamage:AbstractDamage
    {
        public override void ExecuteDamage(DamageType type, int amount)
        {
            Console.WriteLine(amount + " of normal damage");
        }
    }
}
