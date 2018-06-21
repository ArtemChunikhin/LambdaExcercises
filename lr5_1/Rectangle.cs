using System;

namespace lr5_1
{
    class Rectangle
    {
        private Func<Int32, Int32, Int32, ReturnClass> paramRectDelegate;
        public Func<Int32, Int32, Int32, ReturnClass> ParamRectDelegate { get { return paramRectDelegate; } }
        public void SetReference(Func<Int32, Int32, Int32, ReturnClass> target)
        {
            paramRectDelegate = target;
        }
    }
}
