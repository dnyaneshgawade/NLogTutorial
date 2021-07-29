using System;
using System.Collections.Generic;
using System.Text;

namespace NlogProb
{
    class Addition
    {
        static NLog nlog = new NLog();
        public int Add(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                nlog.LogInfo("Sub method");
                nlog.LogDebug("Debug Successful");
                nlog.LogError("First Number or Second Number is zero.");
                return 0;
            }
            int sum = num1+num2;
            nlog.LogInfo("Sub method");
            nlog.LogDebug("Debug Successful");
            nlog.LogWarn("First Number or Second Number is zero.");
            return sum;
        }
    }
}
