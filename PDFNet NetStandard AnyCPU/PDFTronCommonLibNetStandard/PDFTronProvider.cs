using pdftron.Common;
using pdftron.PDF;
using System;
using System.IO;
using System.Reflection;

namespace PDFTronCommonLibNetStandard
{
    public class PDFTronAssemblyLoader
    {
        /// <summary>
        /// Load PDFTronAssemblyLoader for runtime PDFNet loading.
        /// Loads PDFTronDoNet.dll's from either 'win-x86 | win-x64'
        /// folders in current working directory.
        /// </summary>
        public static PDFTronAssemblyLoader Instance()
        {
            return _singleton;
        }

        public PDFTronAssemblyLoader()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }

        /// <summary>
        /// Resolve the loading of the PDFTronDoNet assembly
        /// </summary>
        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return LoadAssemblies();
        }

        /// <summary>
        /// Use reflection to load the correct x64 or x86 assembly needed
        /// </summary>
        public Assembly LoadAssemblies()
        {
            if (Environment.Is64BitOperatingSystem)
                return Assembly.LoadFrom("win-x64/PDFTronDotNet.dll");
            else
                return Assembly.LoadFrom("win-x86/PDFTronDotNet.dll");
        }


        private static readonly PDFTronAssemblyLoader _singleton = new PDFTronAssemblyLoader();

        static PDFTronAssemblyLoader()
        {
            // Just a blank static constructor to force initializers to run first and in the order of declaration.
        }
    }

    /// <summary>
    /// Common place for all pdftron logic which can be consumed by different .NET apps
    /// </summary>
    public class PDFTronProvider
    {
        private static string key = "demo:1632177260189:78c767d103000000007caed1bc2bc23ab6a64d7ddc59caa0651067f800";

        public static void Initialize()
        {
            pdftron.PDFNet.Initialize(key);
        }

        public static bool TestPDFs()
        {
            try
            {
                var path = @"D:\1_third_partySigned.pdf";
                using (PDFDoc doc = new PDFDoc(path))
                {
                    if (!doc.InitSecurityHandler())
                    {
                        Console.WriteLine("Document authentication error...");
                        return false;
                    }

                    return doc.HasSignatures();
                }
            }
            catch (PDFNetException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                pdftron.PDFNet.Terminate();
            }
            return false;

        }
    }
}
