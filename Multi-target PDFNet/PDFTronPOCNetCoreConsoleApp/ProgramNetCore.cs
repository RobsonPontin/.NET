using PDFTronCommonLibNet5NetStandard;
using System;

namespace PDFTronPOCNetCoreConsoleApp
{
    class ProgramNetCore
    {
        static void Main(string[] args)
        {
            PDFTronProvider.initialize();
            PDFTronProvider.TestPDFs();
            Console.WriteLine("Hello World!");
        }
    }
}
