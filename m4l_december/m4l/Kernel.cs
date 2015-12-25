using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.HAL;

namespace m4l
{
    public class Kernel : Sys.Kernel
    {
        //TODO fix by adding ring 2 project, remove this from ring 2, and follow instructions on COSMOS wiki
        //
        VGAScreen screen;
        protected override void BeforeRun()
        {
            screen = new VGAScreen();
            screen.SetGraphicsMode(VGAScreen.ScreenSize.Size640x480, VGAScreen.ColorDepth.BitDepth16);
            for (int i = 0; i < 639; i++)
                for (int j = 0; j < 479; j++)
                    screen.SetPixel640x480x4((uint)i, (uint)j, 0);
        }

        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep();
            while (1==1)
            {
                Console.ReadLine();
            }
        }
    }
}
