using PDFTronCommonLibNet5NetStandard;
using System;

namespace PDFTronPOCNet6ConsoleApp
{
    class ProgramNet6
    {
        static void Main(string[] args)
        {

            PDFTronProvider.initialize();
            PDFTronProvider.TestPDFs();
            Console.WriteLine("Hello World!");

        }
    }
}
