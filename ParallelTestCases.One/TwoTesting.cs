using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParallelTestCases.One
{
    [TestClass]
    public class TwoTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            new Common.TestCaseScenario().DoSomething(string.Format("{0}.{1}", this.GetType().FullName, new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name), 200);
        }

        [TestMethod]
        public void TestMethod2()
        {
            new Common.TestCaseScenario().DoSomething(string.Format("{0}.{1}", this.GetType().FullName, new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name), 200);
        }
    }
}
