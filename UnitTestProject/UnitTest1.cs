using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KLIKER1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        MainWindow wnd = new MainWindow();
        long point = 0;
        static int click = 1;

        [TestMethod]
        public void ClickImgTest()
        {
            // 1 
            long resultPoints = 1;
            Assert.AreEqual(resultPoints, wnd.IncrPoint(point, click));

            // 2
            point = 200;
            click = 4;
            resultPoints = 204;
            Assert.AreEqual(resultPoints, wnd.IncrPoint(point, click));

            // 3
            point = 84;
            click = 16;
            resultPoints = 100;
            Assert.AreEqual(resultPoints, wnd.IncrPoint(point, click));

            // 4
            point = 20;
            click = 20;
            resultPoints = 40;
            Assert.AreEqual(resultPoints, wnd.IncrPoint(point, click));

        }

    }
}
