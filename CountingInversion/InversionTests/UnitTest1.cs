using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountingInversion;

namespace InversionTests
{
    [TestClass]
    public class UnitTest1
    {

        public Inversion CreateInversion()
        {
            return new Inversion();
        }

        [TestMethod]
        public void Inveresion_size2_result1()
        {
            var sut = CreateInversion();
            Assert.AreEqual(1, sut.GetSplitPLace(2));
        }

        [TestMethod]
        public void Inversion_size3_result2()
        {
            var sut = CreateInversion();
            Assert.AreEqual(1, sut.GetSplitPLace(3)); 
        }


        [TestMethod]
        public void Inversion_size13_result6()
        {
            var sut = CreateInversion();
            Assert.AreEqual(6, sut.GetSplitPLace(13));
        }


    }
}
