using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Red;

       
        [TestMethod]


        public void TestMethod1()
        {
            var t = new KiranAle_CompI.Triangle();
            int ai1 = 100, bi1 = 200, ai2 = 200, bi2 = 200, aii1 = 200, bii1 = 200, aii2 = 200, bii2 = 200, biii1 = 200,byiii1 = 200, aiii2 = 200, biii2 = 200;
            t.set(texturestyle, bb, c1, ai1, bi1, ai2, bi2, aii1, bii1, aii2, bii2, aiii1, biii1, aiii2, biii2);
            Assert.AreEqual(100, t.ai1);
        }
    }
}
