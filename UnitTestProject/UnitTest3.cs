using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KLIKER1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        MainWindow wnd = new MainWindow();
        long point = 0;
        static int click = 1;

        [TestMethod]
        public void Btn2()
        {
            point = 499;
            Assert.IsFalse(wnd.Upgraded(point, 2));
            point = 1500;
            Assert.IsTrue(wnd.Upgraded(point, 2));

            click = 10;
            int resultClick = 20;
            Assert.AreEqual(resultClick, wnd.IncreaseClick(click, 2));

            point = 2000;
            long resultPoint = 772;
            Assert.AreEqual(resultPoint, wnd.DecPoint(point, 2));


        }

    }
}
