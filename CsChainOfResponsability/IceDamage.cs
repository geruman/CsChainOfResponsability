using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsChainOfResponsability
{
    public class IceDamage:AbstractDamage
    {
        public override void ExecuteDamage(DamageType type, int amount)
        {
            if (DamageType.ICE == type)
            {
                Console.WriteLine(amount + " of ICE damage");
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
