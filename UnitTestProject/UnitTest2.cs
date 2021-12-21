using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KLIKER1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        MainWindow wnd = new MainWindow();
        long point = 0;
        static int click = 1;

        [TestMethod]
        public void Btn1()
        {
            point = 0;
            Assert.IsFalse(wnd.Upgraded(point, 1));
            point = 312;
            Assert.IsTrue(wnd.Upgraded(point, 1));

            click = 1;
            int resultClick = 4;
            Assert.AreEqual(resultClick, wnd.IncreaseClick(click, 1));

            point = 312;
            long resultPoint = 0;
            Assert.AreEqual(resultPoint, wnd.DecPoint(point, 1));


        }

    }
}
