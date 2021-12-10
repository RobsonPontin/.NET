## Description

This project contains a common library `PDFTronCommonLibNetStandard` where the common PDFTron logic resides and works as a provider for different .NET applications.
This library targets `PDFTronDotNet.dll` (.NET Standard 2.0 lib) and native `PDFNet.dll` for x64 and x86.

Any app consuming this library needs to use `PDFTronAssemblyLoader` to load the correct native assembly (x64 or x86) in runtime, which is done by checking `Environment.Is64BitOperatingSystem` state. 

