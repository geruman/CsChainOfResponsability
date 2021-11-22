using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsChainOfResponsability
{
    public abstract class AbstractDamage
    {
        protected AbstractDamage nextLink;
        public void SetNextLink(AbstractDamage next)
        {
            nextLink = next;
        }
        public abstract void ExecuteDamage(DamageType type, int amount);
    }
}
