using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelTestCases.Common
{
    public class TestCaseScenario
    {
        public void DoSomething(string message, int runSenconds = 1)
        {
            Console.WriteLine(string.Format("[{0:yyyy-MM-dd HH:mm:ss:fff}] Start run {1}", DateTime.Now, message));

            int count = runSenconds * 2;
            for (int i = 0; i < runSenconds; i++)
            {
                Console.WriteLine(string.Format("[{0:yyyy-MM-dd HH:mm:ss:fff}] Sleeping {1}", DateTime.Now, message));
                System.Threading.Thread.Sleep(new Random().Next(400, 600));
            }
            Console.WriteLine(string.Format("[{0:yyyy-MM-dd HH:mm:ss:fff}] End run {1}", DateTime.Now, message));
        }
    }
}
