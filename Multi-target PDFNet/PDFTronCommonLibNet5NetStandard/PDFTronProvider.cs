using pdftron.Common;
using pdftron.PDF;
using System;
using System.IO;

namespace PDFTronCommonLibNet5NetStandard
{
    public class PDFTronProvider
    {
        private static pdftron.PDFNetLoader loader = pdftron.PDFNetLoader.Instance();
        private static string key = "demo:1632177260189:78c767d103000000007caed1bc2bc23ab6a64d7ddc59caa0651067f800";

        public static void initialize()
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
