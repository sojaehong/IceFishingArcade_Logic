using System;
using IceFishingArcade.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IceFishingArcade.Tests
{
    [TestClass]
    public class FishFactoryTest
    {
        [TestMethod]
        public void 오징어가_제대로_생성되는지_확인()
        {
            Fish f = FishFactory.Create(FishType.Squid);

            Assert.AreEqual(f.FishName, "오징어");
        }

        [TestMethod]
        public void 돌고래가_제대로_생성되는지_확인()
        {
            Fish f = FishFactory.Create(FishType.Dolphin);

            Assert.AreEqual(f.FishName, "돌고래");
        }

        [TestMethod]
        public void 돌고래의_등급이_희귀로_생성되는지_확인()
        {
            Fish f = FishFactory.Create(FishType.Dolphin);

            Assert.AreEqual(f.FishGrade, "희귀");
        }
    }
}
