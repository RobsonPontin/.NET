using PDFTronCommonLibNetStandard;
using System;
using System.Reflection;

namespace PDFTronPOCNet5ConsoleApp
{
    class ProgramNet5
    {
        // NOTE: Necessary to properly load assemblies (x64 or x86) in runtime
        private static PDFTronAssemblyLoader pDFTronAssemblyLoader = PDFTronAssemblyLoader.Instance();
        static ProgramNet5() { }

        static void Main(string[] args)
        {
            PDFTronProvider.Initialize();
            PDFTronProvider.TestPDFs();
            Console.WriteLine("Hello World!");
        }
    }
}
