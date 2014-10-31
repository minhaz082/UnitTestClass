using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestApp;

namespace CalculatorTest
{
    [TestFixture]
  public  class CalculatorTest
    {
        [Test]

      public void ADDTEST_CHECK_IF_CAN_ADD_TWO_POSITIVE_NUMBERS()
      {
          Calculator aCalculator=new Calculator();
          
          Assert.AreEqual(-5.07, aCalculator.Add(-2.00,-3.07));
      }
    }
}
