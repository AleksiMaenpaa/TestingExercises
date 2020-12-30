using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;

namespace ArmorTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLevel1()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int lvl = ar.getLevel();

            if (lvl != 2)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestLevel2()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int lvl = ar.getLevel();
            Assert.IsNotNull(lvl);
        }
        [TestMethod]
        public void TestCondition1()
        {
            Armour cd = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            string cond = cd.getCondition();
            Assert.IsNotNull(cond);
        }
        [TestMethod]
        public void TestCondition2()
        {
            Armour cd = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int curr = cd.getCurProt();
            int maxpro = cd.getMaxProt();

            if (curr / maxpro > 1)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestCurrentValue1()
        {
            Armour cd = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int curr = cd.getCurProt();
            Assert.IsNotNull(curr);
        }
        [TestMethod]
        public void TestMaxValue1()
        {
            Armour cd = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int max = cd.getMaxProt();
            Assert.IsNotNull(max);
        }
        [TestMethod]
        public void TestRepair1()
        {

            Armour cd = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int max = cd.getMaxProt();
            cd.repair(10);

            if (cd.getCurProt() <= 0)
            {
                Assert.Fail();
            }
            else if (cd.getCurProt() > 20)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestDam1()
        {
            Armour cd = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int curr = cd.getCurProt();
            Assert.IsNotNull(curr);

        }
        [TestMethod]
        public void TestRepair2()
        {
            Armour cd = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int max = cd.getMaxProt();
            int cur = cd.getCurProt();

            int Expected = 20;

            if ((cur + 20) > max)
            {
                cur = max;
            }
            else
            {
                cur = cur + 20;
            }

            Assert.AreEqual(Expected, max);

        }
        [TestMethod]
        public void TestSlot1()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int Expected = 2;
            int slot = ar.getSlot();
            Assert.AreEqual(Expected, slot);
        }
        [TestMethod]
        public void TestSlot2()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int slot = ar.getSlot();
            Assert.IsNotNull(slot);
        }
        [TestMethod]
        public void TestDam2()
        {
            Armour cd = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int max = cd.getMaxProt();
            int cur = cd.getCurProt();

            int Expected = 0;

            if ((cur - 20) < 0)
            {
                cur = 0;
            }
            else
            {
                cur -= 20;
            }

            Assert.AreEqual(Expected, cur);
        }
    }
}
