using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsChainOfResponsability
{
    public class MagicDamage:AbstractDamage
    {
        public override void ExecuteDamage(DamageType type, int amount)
        {
            if (DamageType.MAGIC == type)
            {
                Console.WriteLine(amount + " of magic damage");
            }
            else
            {
                if (nextLink != null)
                {
                    nextLink.ExecuteDamage(type, amount);
                }
            }
        }
    }
}
