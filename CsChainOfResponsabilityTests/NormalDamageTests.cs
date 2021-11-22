using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsChainOfResponsability.Tests
{
    [TestClass()]
    public class NormalDamageTests
    {
        [TestMethod()]
        public void ExecuteDamageTest()
        {
            AbstractDamage damage = new NormalDamage();
            Assert.IsTrue(damage is NormalDamage);
        }
    }
}