using PDFTronCommonLibNet5NetStandard;
using System;

namespace PDFTronPOCNet5ConsoleApp
{
    class ProgramNet5
    {
        static void Main(string[] args)
        {

            PDFTronProvider.initialize();
            PDFTronProvider.TestPDFs();
            Console.WriteLine("Hello World!");

        }
    }
}
