using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KiranAle_CompI;


namespace UnitTest
{
    [TestClass]
    public class RectangleTest
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;
        
        public RectangleTest()
        {

        }


        private TestContext testContextInstance;

        
        ///Gets or sets the test 
        ///information  and functionality for the current test run.
 
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }



        [TestMethod]
        public void TestMethod1()
        {
            var r = new KiranAle_CompI.Rectangle();
            int a = 200, b = 200, size = 100, size1 = 100;
            r.set(texturestyle, bb, c1, a, b, size, size1);
            Assert.AreEqual(200, r.a);
        }
    }
}
