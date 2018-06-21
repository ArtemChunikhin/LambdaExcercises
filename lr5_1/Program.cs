using System;

namespace lr5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            ReturnClass returnValue = new ReturnClass();
            rectangle.SetReference((a, b, c) =>
            {
                Int32 areaRect = a * b;
                Int32 areaSquare = c * 4;
                if (areaRect < areaSquare)
                {
                    throw new ApplicationException("Area square is more than rectangle area");
                }
                else
                {
                    returnValue.CountSquare = areaRect / areaSquare;
                    returnValue.FreeSpace = areaRect % areaSquare;
                    return returnValue;
                }
            });
            UI ui = new UI();
            ui.Input();
            try
            {
                ui.Output(rectangle.ParamRectDelegate(ui.A_Param, ui.B_Param, ui.C_Param));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
