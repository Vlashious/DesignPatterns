using System;

namespace Template_Method
{
    class OddMethod : AbstractMethod
    {
        public override bool CheckNumber(int num)
        {
            return num % 2 != 0;
        }

        public override void LogInformation()
        {
            Console.WriteLine("This is an odd number.");
        }
    }
}