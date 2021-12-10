
using PDFTronCommonLibNet5NetStandard;
using System;
using System.Reflection;

namespace PDFTronPOCNetFx472ConsoleApp
{
    class ProgramNetFx472
    {
        // NOTE: Necessary to properly load assemblies (x64 or x86) in runtime
        private static PDFTronAssemblyLoader pDFTronAssemblyLoader = PDFTronAssemblyLoader.Instance();
        static ProgramNetFx472() { }

        static void Main(string[] args)
        {
            PDFTronProvider.Initialize();
            PDFTronProvider.TestPDFs();
            Console.WriteLine("Hello World!");
        }


    }
}
