using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KLIKER1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest4
    {
        MainWindow wnd = new MainWindow();
        long point = 0;
        static int click = 1;

        [TestMethod]
        public void Btn3()
        {
            point = 1200;
            Assert.IsFalse(wnd.Upgraded(point, 3));
            point = 50000;
            Assert.IsTrue(wnd.Upgraded(point, 3));

            click = 20;
            int resultClick = 50;
            Assert.AreEqual(resultClick, wnd.IncreaseClick(click, 3));

            point = 50000;
            long resultPoint = 47252;
            Assert.AreEqual(resultPoint, wnd.DecPoint(point, 3));


        }

    }
}
