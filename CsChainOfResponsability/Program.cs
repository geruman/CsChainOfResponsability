using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDamage rootDamageResponder = new FireDamage();
            AbstractDamage iceDamage = new IceDamage();
            AbstractDamage magicDamage = new MagicDamage();
            AbstractDamage normalDamage = new NormalDamage();
            rootDamageResponder.SetNextLink(iceDamage);
            iceDamage.SetNextLink(magicDamage);
            magicDamage.SetNextLink(normalDamage);

            rootDamageResponder.ExecuteDamage(DamageType.NORMAL, 19);
            rootDamageResponder.ExecuteDamage(DamageType.MAGIC, 9);
            rootDamageResponder.ExecuteDamage(DamageType.ICE, 12);
            rootDamageResponder.ExecuteDamage(DamageType.FIRE, 10);
            Console.ReadKey();

        }
    }
}
