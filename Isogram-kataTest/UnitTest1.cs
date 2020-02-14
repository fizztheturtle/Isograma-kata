using System;
using NUnit.Framework;

namespace Isogram_kata
{
   
    public class UnitTest1
    {
       


        [Test]
        public void TestMethod1()
        {
            IsIsogram()
            Assert.Equals(true, IsIsogram());
        }
    }
}
