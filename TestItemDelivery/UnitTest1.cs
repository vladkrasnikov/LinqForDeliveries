using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UsingLinqOnItems;

namespace TestItemDelivery
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTask1()
        {
            Assert.IsTrue(120 == Program.Task1(1));
            Assert.IsTrue(100 == Program.Task1(2));
            Assert.IsTrue(50 == Program.Task1(3));
            Assert.IsTrue(125 == Program.Task1(4));
            Assert.IsTrue(250 == Program.Task1(5));
            Assert.IsTrue(70.5 == Program.Task1(6));
            Assert.IsTrue(70 == Program.Task1(7));
            Assert.IsTrue(100 == Program.Task1(8));
            Assert.IsTrue(50 == Program.Task1(9));
            Assert.IsTrue(500 == Program.Task1(10));
        }
        [TestMethod]
        public void TestTask2Apple()
        {
            string cheapApple = "IphoneSupplier";
            Assert.AreEqual(cheapApple, Program.Task2("Apple"));
        }
        [TestMethod]
        public void TestTask2Samsung()
        {
            string cheapSamsung = "SamSupplier" + "SgSupplier";
            Assert.AreEqual(cheapSamsung, Program.Task2("Samsung"));
        }
        [TestMethod]
        public void TestTask2Lenovo()
        {
            string cheapLenovo = "LenovoSupplier" + "PremiumSupplier";
            Assert.AreEqual(cheapLenovo, Program.Task2("Lenovo"));
        }
        [TestMethod]
        public void TestTask2Xiaomi()
        {
            string cheapXiaomi = "GESupplier";
            Assert.AreEqual(cheapXiaomi, Program.Task2("Xiaomi"));
        }
        [TestMethod]
        public void TestTask2PocoAndHTC()
        {
            string cheapPocoAndHTC = "KMSupplier" + "ESSupplier";
            Assert.AreEqual(cheapPocoAndHTC, Program.Task2("Poco") + Program.Task2("HTC"));
        }
        [TestMethod]
        public void TestTask2Huawei()
        {
            string cheapHuawei = "SKSupplier";
            Assert.AreEqual(cheapHuawei, Program.Task2("Huawei"));
        }
        [TestMethod]
        public void TestTask2OnePlus()
        {
            string cheapOnePlus = "PLSupplier";
            Assert.AreEqual(cheapOnePlus, Program.Task2("OnePlus"));
        }
        [TestMethod]
        public void TestTask2Nokia()
        {
            string cheapNokia = "SMSupplier";
            Assert.AreEqual(cheapNokia, Program.Task2("Nokia"));
        }
        [TestMethod]
        public void TestTask3()
        {
            Dictionary<string, decimal> prubytok = new Dictionary<string, decimal>();
            prubytok.Add("Apple", 59580);
            prubytok.Add("Samsung", 133850);
            prubytok.Add("Lenovo", 21357);
            prubytok.Add("Xiaomi", 94500);
            prubytok.Add("Poco", 2400);
            prubytok.Add("HTC", 10000);
            prubytok.Add("Huawei", 18750);
            prubytok.Add("OnePlus", 23000);
            prubytok.Add("Nokia", 15000);
            prubytok.Add("Ok", 0);
            Assert.AreEqual(prubytok.ToString(), Program.Task3().ToString());
        }

    }
}
