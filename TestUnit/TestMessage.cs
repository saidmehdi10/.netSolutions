using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnit
{
    [TestClass]
    public class TestMessage
    {
        [TestMethod]
        public void Factorielle_AvecValeur3_Retourne6()
        {
            int valeur = 3;

            int resultat = HelloWorld.Math.Factorielle();
            


            /**/
            /***/
                   Assert.AreEqual(6, resultat);
        }

        /*[TestMethod]
        public void Factorielle_AvecValeur10_Retourne1()
        {
            int valeur = 10;
            int resultat = Math.Factorielle(valeur);
            Assert.AreEqual(1, resultat, "La valeur doit être égale à 1");
        }
        [TestMethod]
        public void Addition_return_2()
        {
            int a = 1;
            int b = 1;
            int resultat = Math.addittion(a, b);
            Assert.AreEqual(2, resultat, "valuer est 2");

        }*/
    }
}
