using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUT;

namespace UnitTestMatte
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            //Skapa
            CMatte Matte = new CMatte();
            double BorVarde = 7;

            //Anropa
            double ArVarde = Matte.Add(3, 4);

            //Jämföra
            Assert.AreEqual(BorVarde, ArVarde);
        }

        [TestMethod]
        public void TestSub()
        {
            //Skapa
            CMatte Matte = new CMatte();
            double BorVarde = 7;

            //Anropa
            double ArVarde = Matte.Sub(14, 7);

            //Jämföra
            Assert.AreEqual(BorVarde, ArVarde);
        }

        [TestMethod]
        public void TestMult()
        {
            //Skapa
            CMatte Matte = new CMatte();
            double BorVarde = 30;

            //Anropa
            double ArVarde = Matte.Mult(5, 6);

            //Jämföra
            Assert.AreEqual(BorVarde, ArVarde);
        }

        [TestMethod]
        public void TestPrim()
        {
            //Skapa
            CMatte Matte = new CMatte();
            bool BorVarde = true;

            //Anropa
            bool ArVarde = Matte.Prim(7);

            //Jämföra
            Assert.AreEqual(BorVarde, ArVarde);
        }

        [TestMethod]
        public void TestEjPrim()
        {
            //Skapa
            CMatte Matte = new CMatte();
            bool BorVarde = false;

            //Anropa
            bool ArVarde = Matte.Prim(8);

            //Jämföra
            Assert.AreEqual(BorVarde, ArVarde);
        }

        [TestMethod]
        public void TestNegPrim()
        {
            //Skapa
            CMatte Matte = new CMatte();
            bool BorVarde = false;

            //Anropa
            bool ArVarde = Matte.Prim(-1);

            //Jämföra
            Assert.AreEqual(BorVarde, ArVarde);
        }
    }
}

