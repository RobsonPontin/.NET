
using PDFTronCommonLibNet5NetStandard;
using System;

namespace PDFTronPOCNetFx472ConsoleApp
{
    class ProgramNetFx472
    {
        static void Main(string[] args)
        {
            PDFTronProvider.initialize();
            PDFTronProvider.TestPDFs();
            Console.WriteLine("Hello World!");
        }
    }
}
