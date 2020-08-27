using System;

namespace Template_Method
{
    abstract class AbstractMethod
    {
        public void TemplateMethod(int num)
        {
            if (CheckNumber(num))
            {
                LogInformation();
            }
        }

        public abstract bool CheckNumber(int num);

        public abstract void LogInformation();
    }
}