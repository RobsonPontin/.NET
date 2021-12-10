using PDFTronCommonLibNet5NetStandard;
using System;
using System.Reflection;

namespace PDFTronPOCNetCoreConsoleApp
{
    class ProgramNetCore
    {
        // NOTE: Necessary to properly load assemblies (x64 or x86) in runtime
        private static PDFTronAssemblyLoader pDFTronAssemblyLoader = PDFTronAssemblyLoader.Instance();
        static ProgramNetCore() { }

        static void Main(string[] args)
        {
            PDFTronProvider.Initialize();
            PDFTronProvider.TestPDFs();
            Console.WriteLine("Hello World!");
        }
    }
}
