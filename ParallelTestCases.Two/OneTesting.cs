using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
namespace ParallelTestCases.Two
{
    [TestClass]
    public class OneTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            new Common.TestCaseScenario().DoSomething(string.Format("{0}.{1}", this.GetType().FullName, new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name), 400);
        }

        [TestMethod]
        public void TestMethod2()
        {
            new Common.TestCaseScenario().DoSomething(string.Format("{0}.{1}", this.GetType().FullName, new System.Diagnostics.StackTrace().GetFrame(0).GetMethod().Name), 400);
        }
    }
}
