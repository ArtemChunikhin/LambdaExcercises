using System;

namespace lr5_1
{
    class UI
    {
        private Int32 a_param, b_param, c_param, out_param;
        public Int32 A_Param { get { return a_param; } }
        public Int32 B_Param { get { return b_param; } }
        public Int32 C_Param { get { return c_param; } }
        public void Input()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Enter positive integers:");
            Console.Write("Enter A: ");
            if (Int32.TryParse(Console.ReadLine(), out out_param) && out_param > 0)
            {
                a_param = out_param;
            }
            Console.Write("\nEnter b: ");
            if (Int32.TryParse(Console.ReadLine(), out out_param) && out_param > 0)
            {
                b_param = out_param;
            }
            Console.Write("\nEnter C: ");
            if (Int32.TryParse(Console.ReadLine(), out out_param) && out_param > 0)
            {
                c_param = out_param;
            }
        }
        public void Output(ReturnClass value)
        {
            Console.WriteLine("************************");
            Console.WriteLine(@"[Count squares in rectangle is {0}] [Free Space: {1}]", value.CountSquare, value.FreeSpace);
        }
    }
}
