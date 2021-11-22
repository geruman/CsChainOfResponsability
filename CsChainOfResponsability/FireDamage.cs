using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsChainOfResponsability
{
    public class FireDamage : AbstractDamage
    {
        public override void ExecuteDamage(DamageType type, int amount)
        {
            if(DamageType.FIRE == type)
            {
                Console.WriteLine(amount + " of fire damage");
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
